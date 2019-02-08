using Microsoft.Extensions.Logging;
using Serilog;
using System;

namespace StreamDeckLib.Logging
{
    public static class StreamDeckLibLoggerFactoryExtension
		{
			public static ILoggerFactory AddDefaultLogging(this ILoggerFactory loggerFactory)
			{
				if (loggerFactory == null)
				{
					loggerFactory = new LoggerFactory();
				}

				loggerFactory.AddSerilog(Log.Logger);

				return loggerFactory;
		}
  }
}
