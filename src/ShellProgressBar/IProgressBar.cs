using System;

namespace ShellProgressBar
{
	public interface IProgressBar : IDisposable
	{
		ChildProgressBar Spawn(long maxTicks, string message, ProgressBarOptions options = null);

		void Tick(string message = null);
		void Tick(long newTickCount, string message = null);

		long MaxTicks { get; set; }
		string Message { get; set; }

		double Percentage { get; }
		long CurrentTick { get; }

		ConsoleColor ForegroundColor { get; set; }

		/// <summary> This writes a new line above the progress bar on the console where <see cref="Message"/> updates the message inside the progress bar</summary>
		void WriteLine(string message);

		IProgress<T> AsProgress<T>(Func<T, string> message = null, Func<T, double?> percentage = null);
	}
}
