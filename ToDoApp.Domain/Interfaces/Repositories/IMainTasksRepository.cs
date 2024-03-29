﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IMainTasksRepository : IRepository<MainTask>
    {
        public IEnumerable<MainTask> GetAllMainTasks();
    }
}
