using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Drawing;
using System.Data.Objects.DataClasses;

namespace AppCommon.Util
{
    public class Exporter<T> where T : EntityObject
    {
        private string _reportFile;
        private IEnumerable<IEnumerable<T>> _dataSets;

        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        public Exporter(string reportFile, params IEnumerable<T>[] dataSets)
        {
            _dataSets = dataSets;
            _reportFile = reportFile;
        }

        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>9.02in</PageWidth>
                <PageHeight>12.8in</PageHeight>
                <MarginTop>0.1in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);

            //Extend adding code (khoatd)
            m_streams.RemoveAt(m_streams.Count - 1);

            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        // Create a local report for Report.rdlc, load the data,
        //    export the report to an .emf file, and print it.
        public void Run()
        {
            LocalReport report = new LocalReport();
            report.ReportEmbeddedResource = _reportFile;// "PosSystem.Models.Sale.OrderInvoice.rdlc";

            foreach (var data in _dataSets)
            {
                if (data.Count() <= 0) continue;

                var name = data.First().GetType().Name + "DS";
                report.DataSources.Add(new ReportDataSource(name, data));
            }
            Export(report);
            Print();
        }

    }
}
