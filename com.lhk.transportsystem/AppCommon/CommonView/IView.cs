//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : @ ShoppingCentral
//  @ File Name : cs
//  @ Date : 2/21/2013
//  @ Author :  kenjuzi
//
//

namespace AppCommon.CommonView
{
    public interface IView
    {
        bool isFocus();
        void HandleBarcodeHit(string barcode);
        bool HandleCreateNew();
        void HandleDelete();
        bool HandleEdit();
        void HandlePrint();
        bool HandleSaveTask();
        void HandleCancelTask();
        void HandleSearch();
        void HandleExport();
        void HandleHelp();
    }
}