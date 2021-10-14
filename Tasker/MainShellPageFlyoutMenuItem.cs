using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker
{
    public class MainShellPageFlyoutMenuItem
    {
        public MainShellPageFlyoutMenuItem()
        {
            TargetType = typeof(MainShellPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public object Tag { get; set; }
        public Type TargetType { get; set; }
    }
}