using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string contact)
    {
      Job myJob = new Job(title, description, contact);
      myJob.Title = title;
      myJob.Description = description;
      myJob.Contact = contact;
      
      return RedirectToAction("Index");
    }

  }
}