using Lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        int title;
        public int Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        int description;
        public int Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }


        ObservableCollection<TaskModel> tasks;

        internal List<TaskModel> TaskModels { get; }

        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; } 
            set 
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        private List<TaskModel> TaskModel;
        public TaskViewModel()
        {
            tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.Title = this.Title;
                TaskModel.Add(task);
            });
            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModels>;
            });

        }
    }
}
