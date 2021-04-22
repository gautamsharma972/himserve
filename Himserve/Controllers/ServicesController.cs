using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Himserve.Services;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Himserve.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index(string service="")
        {
            if(service == "agriculture")
            {
                ViewData["PageTitle"] = "Agriculture & Animal Husbandary";
            }
            else if(service == "child")
            {
                ViewData["PageTitle"] = "Child To Child & Adolescent Groups";
            }
            else if (service == "community-health")
            {
                ViewData["PageTitle"] = "Community Health Volunteers";
            }
            else if (service == "emergency-relief-service")
            {
                ViewData["PageTitle"] = "Emergency Relief Service";
            }
            else if(service == "health-resource-library")
            {
                ViewData["PageTitle"] = "Himalayan Health Resource Library";
            }
            else if(service == "holistic-training")
            {
                ViewData["PageTitle"] = "Holistic Training";
            }
            else if(service == "rural-education")
            {
                ViewData["PageTitle"] = "Rural Education and Teacher Training";
            }
            else if(service == "special-projects")
            {
                ViewData["PageTitle"] = "Special Projects";
            }
            else if(service == "village-development")
            {
                ViewData["PageTitle"] = "Village Development Committees & Self Help Groups";
            }
            else if(service == "grace-student")
            {
                ViewData["PageTitle"] = "Grace Student's Hostel";
            }
            ViewData["service"] = service;
            return View();
        }

        public IActionResult AmbulanceService(string type = "")
        {
            if (type == "")
            {
                return NotFound();
            }
            switch (type) {
                case "the-donkey":
                    return PartialView("_TheDonkeyService");
                    break;
                case "the-rhino":
                        return PartialView("_TheRhinoService");
                    break;
                case "the-mule":
                    return PartialView("_TheMuleService");
                    break;
                case "the-elephant":
                    return PartialView("_TheElephant");
                    break;
                case "the-colt":
                    return PartialView("_TheColt");
                default:
                    return NotFound();
            }
        }

        public IActionResult HealthServices(string type = "")
        {
            if (type == "")
            {
                return NotFound();
            }
            switch (type) {
                case "nutrition":
                    return PartialView("_NutritionHealthService");
                case "chw-skills":
                    return PartialView("_CHWSkills");
                case "first-aid":
                    return PartialView("_FirstAid");
                case "sick-children":
                    return PartialView("_SickChildren");
                case "facts-for-life":
                    return PartialView("_FactsForLife");
                case "birth-emergency":
                    return PartialView("_BirthEmergency");
                case "hygiene-sanitization":
                    return PartialView("_HygieneSanitization");
                case "newborn-care":
                    return PartialView("_NewbornCare");
                case "mobile-apps":
                    return PartialView("_MobileApps");
                case "online-resources":
                    return PartialView("_OnlineResources");
                case "publications":
                    return PartialView("_Publications");
                case "safe-motherhood":
                    return PartialView("_SafeMotherhood");
                default:
                    return NotFound();

            }
        }
    }
}
