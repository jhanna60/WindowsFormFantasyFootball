using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormFantasyFootball
{
    public class AutomaticSub
    {
        public int id { get; set; }
        public int element_in { get; set; }
        public int element_out { get; set; }
        public int entry { get; set; }
        public int @event { get; set; }
    }

    public class EntryHistory
    {
        public int id { get; set; }
        public string movement { get; set; }
        public int points { get; set; }
        public int total_points { get; set; }
        public int rank { get; set; }
        public int rank_sort { get; set; }
        public int overall_rank { get; set; }
        public object targets { get; set; }
        public int event_transfers { get; set; }
        public int event_transfers_cost { get; set; }
        public int value { get; set; }
        public int points_on_bench { get; set; }
        public int bank { get; set; }
        public int entry { get; set; }
        public int @event { get; set; }
    }

    public class Pick
    {
        public int element { get; set; }
        public int position { get; set; }
        public bool is_captain { get; set; }
        public bool is_vice_captain { get; set; }
        public int multiplier { get; set; }
    }

    public class MyTeam
    {
        public string active_chip { get; set; }
        public List<AutomaticSub> automatic_subs { get; set; }
        public EntryHistory entry_history { get; set; }
        public List<Pick> picks { get; set; }
    }

}
