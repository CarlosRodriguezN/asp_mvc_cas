using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_mvc_cas.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        private EventLog evtSistemaBienestar;

        // GET: Secret
        public ActionResult Index()
        {

            //this.evtSistemaBienestar = new EventLog();
            //this.evtSistemaBienestar.Log = "SistemaBienestarEstudiantil";

            //if (!EventLog.SourceExists("SistemaBienestarEstudiantil")){
            //    //  An event log source should not be created and immediately used.
            //    //  There is a latency time to enable the source, it should be created
            //    //  prior to executing the application that uses the source.
            //    //  Execute this sample a second time to use the new source.
            //    EventSourceCreationData eventosSistemaBienestar = new EventSourceCreationData("MySource", "MyNewLog");

            //    EventLog.CreateEventSource( eventosSistemaBienestar );
            //    Console.WriteLine("CreatedEventSource");
            //    Console.WriteLine("Exiting, execute the application a second time to use the source.");

            //    //  The source is created.  Exit the application to allow it to be registered.
            //    return View();
            //}

            ////  Create an EventLog instance and assign its log name.
            //EventLog myLog = new EventLog("myNewLog", "myServer");

            ////  Read the event log entries.
            //foreach (EventLogEntry entry in myLog.Entries){
            //    Console.WriteLine("\tEntry: " + entry.Message);
            //}

            return View();
        }
    }
}