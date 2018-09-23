using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Paderov Evgeny
/// </summary>
namespace GU_Algorithms
{

	class Program
	{
		// 5 урок
		static void Main(string[] args)
		{
			#region 6. *Реализовать очередь.
			Queue q = new Queue();
			q.Enqueue(new QueueNode("1"));
			q.Enqueue(new QueueNode("2"));
			q.Enqueue(new QueueNode("3"));
			q.Enqueue(new QueueNode("4"));
			q.Enqueue(new QueueNode("5"));

			for (int i = 0; i < q.Length;)
			{
				Console.WriteLine(q.Dequeue().Value);
			}
			#endregion

			#region 3. Написать программу, которая определяет, является ли введенная скобочная последовательность правильной.

			Console.WriteLine(CheckParenthesesSequence("[2/{5*(4+7)}]"));
			Console.WriteLine(CheckParenthesesSequence("(2+(2*2))"));
			Console.WriteLine(CheckParenthesesSequence("()()()())({}{_}}{}{{}}}}"));
			#endregion

			Console.ReadKey();
		}


		/// <summary>
		/// 3. Написать программу, которая определяет, является ли введенная скобочная последовательность правильной. 
		/// Примеры правильных скобочных выражений: (),([])(), {}(), ([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [,(,{.
		/// Например: (2+(2*2)) или[2 /{5*(4+7)}]
		/// </summary>
		private static bool CheckParenthesesSequence(string seq)
		{
			Stack<Char> stack = new Stack<Char>();

			foreach (Char c in seq)
			{
				if (c == '(' || c == '{' || c == '[')
				{
					stack.Push(c);
				}
			}

			foreach (Char c in seq)
			{
				if (c == ')' || c == '}' || c == ']')
				{
					//Console.WriteLine($" открывающая скобка: {stack.Peek()} закрывающая скобка: {c}");
					switch (stack.Pop())
					{
						case '(':
							if (c != ')') return false;
							else continue;
						case '{':
							if (c != ')') return false;
							else continue;
						case '[':
							if (c != ')') return false;
							else continue;
						default:
							return true;

					}

				}
			}
			return true;
		}

	}

	// 6. *Реализовать очередь.
	class Queue
	{
		private int length;
		private QueueNode tail;
		private QueueNode head;

		public int Length { get => length; set => length = value; }

		internal Queue()
		{
			length = 0;
			tail = null;
			head = null;
		}

		public void Enqueue(QueueNode n)
		{
			if (head == null)
			{
				head = n;
				tail = n;
				length = 1;
				return;
			}

			tail.Next = n;
			tail = n;
			length++;
		}
		public QueueNode Dequeue()
		{
			if (head == null) throw new NoSuchElementException();

			var h = head;
			head = head.Next;
			length--;
			return h;
		}

	}

	class QueueNode
	{
		private QueueNode next;
		private string value;

		public string Value { get => value; set => this.value = value; }
		public QueueNode Next { get => next; set => next = value; }

		internal QueueNode(string value)
		{
			this.value = value;

		}

	}

	[Serializable]
	internal class NoSuchElementException : Exception
	{
		public NoSuchElementException()
		{
		}

		public NoSuchElementException(string message) : base(message)
		{
		}

		public NoSuchElementException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected NoSuchElementException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}

}

