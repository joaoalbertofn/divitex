using System;

public class TodoItem
{
	public string? Title { get; set; }
	public bool isDone { get; set; }


	public TodoItem()
	{
	}

    public TodoItem(string newTitle)
    {
		this.Title = newTitle;
    }
}


