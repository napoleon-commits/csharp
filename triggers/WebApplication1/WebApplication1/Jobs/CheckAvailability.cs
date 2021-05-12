using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quartz;
using System.Diagnostics;

namespace WebApplication1.Jobs
{
    public class CheckAvailabilityJob : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            try
            {
                Debug.WriteLine("Opponent is not available.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Task.FromResult(0);
        }
    }
}
