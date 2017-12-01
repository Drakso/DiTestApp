using Business.Models;
using Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
	public class PostServices
	{
		List<Record> Db = new List<Record>();
		int id = 1;
		public void Post(string input, List<Record> db)
		{
			try
			{
				db.Add(new Record() { Id = id, Content = input, Posted = DateTime.Now, Type = PostType.Text });
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			id++;
			Console.WriteLine("Someone posted some text: " + input);
			Console.ReadLine();
		}

		public void Post(int input, List<Record> db)
		{
			try
			{
				db.Add(new Record() { Id = id, Content = input, Posted = DateTime.Now, Type = PostType.Text });
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			id++;
			Console.WriteLine("Someone posted some Number: " + input);
			Console.ReadLine();
		}

		public void Post(char input, List<Record> db)
		{
			try
			{
				db.Add(new Record() { Id = id, Content = input, Posted = DateTime.Now, Type = PostType.Text });
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			id++;
			Console.WriteLine("Someone posted some Character: " + input);
			Console.ReadLine();
		}

		public void EditPost(int postId, object content)
		{
			try
			{
				Db.Where(x => x.Id == postId).First().Content = content;
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Post Successfully Edited!");
			Console.ReadLine();
			Console.ResetColor();
		}

		public void DeletePost(int postId)
		{
			try
			{
				Db.Remove(Db.Where(x => x.Id == postId).First());
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Post Successfully Deleted!");
			Console.ReadLine();
			Console.ResetColor();
		}

		public void GetAllPosts(int postId)
		{
			try
			{
				foreach (var post in Db)
				{
					Console.WriteLine(post.Content);
					Console.WriteLine("=================================");
				}
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			Console.ReadLine();
		}

		public void GetPostById(int postId)
		{
			try
			{
				Console.Write(Db.Where(x => x.Id == postId).First().Content);
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			Console.ReadLine();
		}

		public void DeleteAllPosts()
		{
			try
			{
				Db = new List<Record>();
			}
			catch (Exception e)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message);
				Console.ReadLine();
				Console.ResetColor();
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("All posts successfully Deleted");
			Console.ReadLine();
			Console.ResetColor();
		}
	}
}
