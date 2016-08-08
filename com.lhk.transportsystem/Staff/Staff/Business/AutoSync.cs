using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using AppCommon.Util;
using AppCommon.Constant;
using DBManagement;
using AppCommon.CommonView;
using System.Windows.Forms;


namespace Staff
{
    public class AutoSync
    {
        private System.Timers.Timer _loadingTimer;
        private bool _isAllowSync;

        public delegate string AutoLoadDelegate();
        private AutoLoadDelegate _loadFunc;

        private WaitingBox _waitingBox = new WaitingBox();
        private bool _isOpeningWaitingBox;

        private static AutoSync _instance;
        public static AutoSync GetInstance()
        {
            if (_instance == null)
                _instance = new AutoSync();
            return _instance;
        }
        
        private AutoSync()
        {
            _loadingTimer = new System.Timers.Timer();
            _loadingTimer.AutoReset = true;
            _loadingTimer.Enabled = true;
            _loadingTimer.Elapsed += new ElapsedEventHandler(onTimerElapse);

            _loadingTimer.Interval = Constants.AUTOLOAD_TIMER_INTERVAL;
            _loadFunc = new AutoSync.AutoLoadDelegate(new MainBusiness().SyncCommonData);

            _isAllowSync = true;
        }

        ~AutoSync()
        {
            _loadingTimer.Stop();
            _loadingTimer = null;
        }

        protected void onTimerElapse(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (_isAllowSync)
                {
                    _isAllowSync = false;
                    AppLogger.logInfo("[AutoLoadData]", "Begin onTimerElapse");
                    _loadFunc();
                    AppLogger.logInfo("[AutoLoadData]", "Finish onTimerElapse");
                    _isAllowSync = true;

                    if (_isOpeningWaitingBox) StopWorker();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError("[onTimerElapse]", exc.Message);
            }
        }

        public void Start()
        {
            _loadingTimer.Start();
        }

        public void Stop()
        {
            _loadingTimer.Stop();
        }

        public string CheckServerIsFree()
        {
            if (_isAllowSync == false)
            {
                StartWorker();
                return "Máy chủ đang bận. Xin thử lại.";
            }
            return string.Empty;
        }

        private void StartWorker()
        {
            try
            {
                if (_waitingBox == null || _waitingBox.IsDisposed) _waitingBox = new WaitingBox();
                _waitingBox.Show();
                Application.DoEvents();

                _isOpeningWaitingBox = true;
            }
            catch (Exception exc)
            {
                AppLogger.logError("[AutoSync - StartWorker]", exc.Message);
            }
        }

        private void StopWorker()
        {
            _waitingBox.Close();

            _isOpeningWaitingBox = false;
        }
    }
}
