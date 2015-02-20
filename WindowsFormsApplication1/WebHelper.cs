using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace TMG.Web
{
    public class WebHelper
    {        
        /// <summary>
        /// Service Url where to find the desired service
        /// </summary>
        public string ServiceUrl = "http://www.posttestserver.com/post.php";

        /// <summary>
        /// Request Timeout.  Default is 10 seconds
        /// </summary>
        public int Timeout = 90000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public virtual WebResponse SendPostRequest( string endpoint, byte[] requestData )
        {
            WebResponse webResp = null;
           // _Trace.LogMessage( "+SendPostRequest" );

            try
            {
               

                // -- Initialize the web request
                //WebRequest webReq = WebRequest.Create( ServiceUrl +  endpoint );
                /// i tried to learn about what endpoint is and i didnt find any meaningfull resourse.
                /// Please share with me if you find any.
                /// for POST data check
                /// http://www.posttestserver.com/data/2015/02/17/15.17.071347177541
                /// to check new Order run the application and immediately copy and paste http://posttestserver.com/post.php to browser.
                /// and Open Address which is shown in web page and find nearby link to get XML content sent by Application.
                WebRequest webReq = WebRequest.Create("http://posttestserver.com/post.php");

                webReq.Method = "POST";
                webReq.ContentType = "text/xml";
                webReq.Credentials = CredentialCache.DefaultNetworkCredentials;
                webReq.Timeout = Timeout;
                //MessageBox.Show("Firing the Request");
                // -- Aquire output stream and write their request into it
                Stream outStream = webReq.GetRequestStream();
                outStream.Write( requestData, 0, requestData.Length );
                outStream.Close();
                // -- Fire off request
                webResp = webReq.GetResponse();
                
                Stream inStream = webResp.GetResponseStream();
               
               // _Trace.LogMessage( "+SendPostRequest -- " + inStream.ToString() );
                //_Trace.LogMessage( "-SendPostRequest" );
                MessageBox.Show("Succesfully Sent");
                Debug.WriteLine(webResp);
                return webResp;
            }
            catch ( Exception ex )
            {
                Debug.WriteLine(ex.Message);
                // -- Exception occurred
                //_Trace.LogMessage( String.Format( "+SendPostRequest -- Exception: [{0}]", ex.Message ) );

                //if( ex.InnerException != null )
                   // _Trace.LogMessage( String.Format( "+SendPostRequest -- Exception: [{0}]", ex.InnerException.Message ) );
            }

            //_Trace.LogMessage( "-SendPostRequest" );
            return webResp;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestData"></param>
        /// <returns></returns>
        //public virtual WebResponse SendGetRequest( string endpoint, byte[] requestData = null )
        //{
        //    WebResponse webResp = null;
        //    _Trace.LogMessage( "+SendGetRequest" );

        //    try
        //    {
        //        // -- Initialize the web request
        //        WebRequest webReq = WebRequest.Create( ServiceUrl + endpoint );
        //        webReq.Method = "GET";
        //        webReq.ContentType = "text/xml";
        //        webReq.Timeout = Timeout;

        //        // -- Aquire output stream and write their request into it
        //        if ( requestData != null && requestData.Length > 0 )
        //        {
        //            Stream outStream = webReq.GetRequestStream();
        //            outStream.Write( requestData, 0, requestData.Length );
        //        }

        //        // -- Fire off request
        //        webResp = webReq.GetResponse();
        //        Stream inStream = webResp.GetResponseStream();

        //        _Trace.LogMessage( "+SendGetRequest -- " + inStream.ToString() );
        //        _Trace.LogMessage( "-SendGetRequest" );

        //        return webResp;
        //    }
        //    catch ( Exception ex )
        //    {
        //        // -- Exception occurred
        //        _Trace.LogMessage( String.Format( "+SendGetRequest -- Exception: [{0}]", ex.Message ) );

        //        if ( ex.InnerException != null )
        //            _Trace.LogMessage( String.Format( "+SendGetRequest -- Exception: [{0}]", ex.InnerException.Message ) );
        //    }

        //    _Trace.LogMessage( "-SendGetRequest" );
        //    return webResp;
        //}

    }
}