﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FCFLUC001.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult RicercaProdotti(){
			ViewBag.Messagge = "Benvenuto nella pagina di ricerca prodotto!";
			return View();
		}
		public ActionResult RicercaProdotti(string codice , string descrizione){
			//Luca E Carmen , tocca a voi!
			return View();
		}
		
		public ActionResult DettaglioProdotto(){
			ViewBag.Messagge = " ECCO I DETTAGLI DEL TUO PRODOTTO!";
			return View();
		}

		public ActionResult DettaglioProdotto(int id){
			DomainModels dm = new DomainModels();
			ViewBag.Messagge = " ECCO I DETTAGLI DEL TUO PRODOTTO!";
			ViewBag.prodotto = dm.RicercaId(id);
			return View();
		}
		public ActionResult PreviewRichiesta(){
			return View();
		}
		public ActionResult ElencoProdotti(){
			return View();
		}
		public ActionResult AggiungiCarrello(string codice, string Quantita){
			return View();
		}
		public ActionResult 


	}
}