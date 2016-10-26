using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DriversApp.Models;

namespace DriversApp.ViewModels
{
    public class RuntagViewModel
    {
        private Runtag _model;

        public Runtag Model
        {
            get { return _model; }
        }

        public RuntagViewModel(Runtag model)
        {
            _model = model;
        }

        public RuntagViewModel()
        {
            _model = new Runtag();                
        }

        public int Id
        {
            get { return _model.Id; }
            set { _model.Id = value; }
        }
        [Display(Name = "Titel")]
        [Required]
        public string Title
        {
            get { return _model.Title; }
            set { _model.Title = value; }
        }
        [Display(Name = "Tidspunkt")]
        [Required]
        public DateTime DueTime
        {
            get { return _model.DueTime; }
            set { _model.DueTime = value; }
        }
        [Display(Name = "Adresse")]
        [Required]
        public string Address
        {
            get { return _model.Address; }
            set { _model.Address = value; }
        }
        [Display(Name = "Kundenavn")]
        [Required]
        public string CustomerName
        {
            get { return _model.CustomerName; }
            set { _model.CustomerName = value; }
        }
        [Display(Name = "Beskrivelse")]
        [Required]
        public string Description
        {
            get { return _model.Description; }
            set { _model.Description = value; }
        }
    }
}

