using System;
using System.ComponentModel;

TodoList td=new TodoList();
td.UserInteracton();

public class TodoList
{
    public void UserInteracton()
    {
        Console.WriteLine("Hello");
        List<string> todoList = new List<string>();
        string key;
        bool isValid = true;
        do
        {
            Console.WriteLine("What do you want to do");
            Console.WriteLine("See All Todo");
            Console.WriteLine("Add a Todo");
            Console.WriteLine("Remove a Todo");
            Console.WriteLine("Exit");
            key = Console.ReadLine();
            switch (key)
            {
                case "S":
                    Console.WriteLine("See all Todo");
                    var val=SeeAllTodo();
                    break;
                case "A":
                    var breakLoop = false;
                    do
                    {
                        Console.WriteLine("Add a new description");
                        string description = Console.ReadLine();
                        var result = AddTodo(description);
                        if (!result)
                        {
                            breakLoop = true;
                            Console.WriteLine("Description must be unique");
                        }
                        else
                        {
                            breakLoop= false;
                        }
                    } while (breakLoop);
                    break;
                case "R":
                    Console.WriteLine("Remove all todo");
                    Console.WriteLine("Add description to remove from todolist");
                    var item = Console.ReadLine();
                    if (todoList.Contains(item))
                    {
                        RemoveTodo(item);
                    }
                    else
                    {
                        Console.WriteLine("Item is not in todolist");
                    }
                    break;
                case "E":
                    Console.WriteLine("Press Any key to Exit");
                    Console.ReadKey();
                    isValid = false;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        } while (isValid);

        bool SeeAllTodo()
        {
            for(int i=0;i<todoList.Count;i++)
            {
                Console.WriteLine(todoList[i]);
            }
            return true;
        }

        void RemoveTodo(string description)
        {
            todoList.Remove(description);
        }


        bool AddTodo(string description)
        {
            if(todoList.Contains(description))
            {
                return false;
            }
            else
            {
                todoList.Add(description);
                return true;
            }
        }
    }
}
