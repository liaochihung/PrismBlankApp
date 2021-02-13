using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Prism.Logging;

namespace PrismBlankApp.Logging
{
    public enum Category
    {
        /// <summary>Debug category.</summary>
        Debug,
        /// <summary>Exception category.</summary>
        Exception,
        /// <summary>Informational category.</summary>
        Info,
        /// <summary>Warning category.</summary>
        Warn,
    }

    public enum Priority
    {
        /// <summary>No priority specified.</summary>
        None,
        /// <summary>High priority entry.</summary>
        High,
        /// <summary>Medium priority entry.</summary>
        Medium,
        /// <summary>Low priority entry.</summary>
        Low,
    }

    public interface ILoggerFacade
    {
        /// <summary>
        /// Write a new log entry with the specified category and priority.
        /// </summary>
        /// <param name="message">Message body to log.</param>
        /// <param name="category">Category of the entry.</param>
        /// <param name="priority">The priority of the entry.</param>
        void Log(string message, Category category, Priority priority);
    }

    public class NLogLogger : ILoggerFacade
    {
        #region Members and Constants

        private Logger logger = LogManager.GetCurrentClassLogger();

        #endregion Members and Constants 

        #region ILoggerFacade Members

        /// <summary>
        /// Write a new log entry with the specified category and priority.
        /// </summary>
        /// <param name="message">Message body to log.</param>
        /// <param name="category">Category of the entry.</param>
        /// <param name="priority">The priority of the entry (not used by NLog so we pass Priority.None)</param>
        public void Log(string message, Category category, Priority priority)
        {
            switch (category)
            {
                case Category.Debug:
                    logger.Debug(message);
                    break;
                case Category.Exception:
                    logger.Error(message);
                    break;
                case Category.Info:
                    logger.Info(message);
                    break;
                case Category.Warn:
                    logger.Warn(message);
                    break;
                default:
                    logger.Info(message);
                    break;
            }
        }

        #endregion ILoggerFacade Members
    }
}
