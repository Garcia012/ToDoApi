using ToDoApi.Models;

namespace ToDoApi.Services
{
    public class TaskService
    {
        private readonly List<TaskModel> _tasks = new();
        private int _nextId = 1;

        public List<TaskModel> GetAll()
        {
            return _tasks;
        }

        public TaskModel Add(string title)
        {
            var task = new TaskModel
            {
                Id = _nextId++,
                Title = title,
                IsDone = false
            };

            _tasks.Add(task);
            return task;
        }

        public bool MarkAsDone(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return false;

            task.IsDone = true;
            return true;
        }

        public bool Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return false;

            _tasks.Remove(task);
            return true;
        }
    }
}

