﻿using CefSharp;

namespace WpfApp2
{
    public class RenderProcessMessageHandler_For_Google_Image : IRenderProcessMessageHandler
    {
        // Wait for the underlying `Javascript Context` to be created, this is only called for the main frame.
        // If the page has no javascript, no context will be created.
        void IRenderProcessMessageHandler.OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {
            const string script = @"document.addEventListener('DOMContentLoaded', function()
{



document.getElementById('taw').remove();
document.getElementById('rshdr').remove();
document.getElementById('searchform').remove();
   

});";

            frame.ExecuteJavaScriptAsync(script);
        }

        public void OnContextReleased(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        public void OnFocusedNodeChanged(IWebBrowser browserControl, IBrowser browser, IFrame frame, IDomNode node)
        {

        }

        public void OnUncaughtException(IWebBrowser browserControl, IBrowser browser, IFrame frame, JavascriptException exception)
        {

        }
    }
}