using Avalonia.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = NLog.Logger;

namespace mather_2
{
    class NLogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void NlogInfo(bool startOrStopProgram)
        {
            if (startOrStopProgram == true)
            {
                logger.Info("start of the program");
            }
            else
            {
                logger.Info("stop of the program");
                Console.WriteLine();
            }
        }
        public static void NlogWarnAnswer(string correct_answer, string visibleExpression, int otvet)
        {
            logger.Warn($" example: {visibleExpression}; answer: {otvet}; correct_answer: {correct_answer}");
        }
    }
}
