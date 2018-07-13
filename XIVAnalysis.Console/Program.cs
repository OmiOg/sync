using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XIVAnalysis.Sync.Entities.DTO.XIVDB;

namespace XIVAnalysis.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPagination();
        }

        private static void TestPagination()
        {
            string result = "{\"pagination\":{\"page\":1,\"page_next\":2,\"page_prev\":false,\"page_total\":54,\"results\":250,\"results_per_page\":250,\"results_total\":13301},\"results\":[{\"ID\":0},{\"ID\":1},{\"ID\":2},{\"ID\":3},{\"ID\":4},{\"ID\":5},{\"ID\":6},{\"ID\":7},{\"ID\":8},{\"ID\":9},{\"ID\":10},{\"ID\":11},{\"ID\":12},{\"ID\":13},{\"ID\":14},{\"ID\":15},{\"ID\":16},{\"ID\":17},{\"ID\":18},{\"ID\":19},{\"ID\":20},{\"ID\":21},{\"ID\":22},{\"ID\":23},{\"ID\":24},{\"ID\":25},{\"ID\":26},{\"ID\":27},{\"ID\":28},{\"ID\":29},{\"ID\":30},{\"ID\":31},{\"ID\":32},{\"ID\":33},{\"ID\":34},{\"ID\":35},{\"ID\":36},{\"ID\":37},{\"ID\":38},{\"ID\":39},{\"ID\":40},{\"ID\":41},{\"ID\":42},{\"ID\":43},{\"ID\":44},{\"ID\":45},{\"ID\":46},{\"ID\":47},{\"ID\":48},{\"ID\":49},{\"ID\":50},{\"ID\":51},{\"ID\":52},{\"ID\":53},{\"ID\":54},{\"ID\":55},{\"ID\":56},{\"ID\":57},{\"ID\":58},{\"ID\":59},{\"ID\":60},{\"ID\":61},{\"ID\":62},{\"ID\":63},{\"ID\":64},{\"ID\":65},{\"ID\":66},{\"ID\":67},{\"ID\":68},{\"ID\":69},{\"ID\":70},{\"ID\":71},{\"ID\":72},{\"ID\":73},{\"ID\":74},{\"ID\":75},{\"ID\":76},{\"ID\":77},{\"ID\":78},{\"ID\":79},{\"ID\":80},{\"ID\":81},{\"ID\":82},{\"ID\":83},{\"ID\":84},{\"ID\":85},{\"ID\":86},{\"ID\":87},{\"ID\":88},{\"ID\":89},{\"ID\":90},{\"ID\":91},{\"ID\":92},{\"ID\":93},{\"ID\":94},{\"ID\":95},{\"ID\":96},{\"ID\":97},{\"ID\":98},{\"ID\":99},{\"ID\":100},{\"ID\":101},{\"ID\":102},{\"ID\":103},{\"ID\":104},{\"ID\":105},{\"ID\":106},{\"ID\":107},{\"ID\":108},{\"ID\":109},{\"ID\":110},{\"ID\":111},{\"ID\":112},{\"ID\":113},{\"ID\":114},{\"ID\":115},{\"ID\":116},{\"ID\":117},{\"ID\":118},{\"ID\":119},{\"ID\":120},{\"ID\":121},{\"ID\":122},{\"ID\":123},{\"ID\":124},{\"ID\":125},{\"ID\":126},{\"ID\":127},{\"ID\":128},{\"ID\":129},{\"ID\":130},{\"ID\":131},{\"ID\":132},{\"ID\":133},{\"ID\":134},{\"ID\":135},{\"ID\":136},{\"ID\":137},{\"ID\":138},{\"ID\":139},{\"ID\":140},{\"ID\":141},{\"ID\":142},{\"ID\":143},{\"ID\":144},{\"ID\":145},{\"ID\":146},{\"ID\":147},{\"ID\":148},{\"ID\":149},{\"ID\":150},{\"ID\":151},{\"ID\":152},{\"ID\":153},{\"ID\":154},{\"ID\":155},{\"ID\":156},{\"ID\":157},{\"ID\":158},{\"ID\":159},{\"ID\":160},{\"ID\":161},{\"ID\":162},{\"ID\":163},{\"ID\":164},{\"ID\":165},{\"ID\":166},{\"ID\":167},{\"ID\":168},{\"ID\":169},{\"ID\":170},{\"ID\":171},{\"ID\":172},{\"ID\":173},{\"ID\":174},{\"ID\":175},{\"ID\":176},{\"ID\":177},{\"ID\":178},{\"ID\":179},{\"ID\":180},{\"ID\":181},{\"ID\":182},{\"ID\":183},{\"ID\":184},{\"ID\":185},{\"ID\":186},{\"ID\":187},{\"ID\":188},{\"ID\":189},{\"ID\":190},{\"ID\":191},{\"ID\":192},{\"ID\":193},{\"ID\":194},{\"ID\":195},{\"ID\":196},{\"ID\":197},{\"ID\":198},{\"ID\":199},{\"ID\":200},{\"ID\":201},{\"ID\":202},{\"ID\":203},{\"ID\":204},{\"ID\":205},{\"ID\":206},{\"ID\":207},{\"ID\":208},{\"ID\":209},{\"ID\":210},{\"ID\":211},{\"ID\":212},{\"ID\":213},{\"ID\":214},{\"ID\":215},{\"ID\":216},{\"ID\":217},{\"ID\":218},{\"ID\":219},{\"ID\":220},{\"ID\":221},{\"ID\":222},{\"ID\":223},{\"ID\":224},{\"ID\":225},{\"ID\":226},{\"ID\":227},{\"ID\":228},{\"ID\":229},{\"ID\":230},{\"ID\":231},{\"ID\":232},{\"ID\":233},{\"ID\":234},{\"ID\":235},{\"ID\":236},{\"ID\":237},{\"ID\":238},{\"ID\":239},{\"ID\":240},{\"ID\":241},{\"ID\":242},{\"ID\":243},{\"ID\":244},{\"ID\":245},{\"ID\":246},{\"ID\":247},{\"ID\":248},{\"ID\":249}]}";

            var test = JsonConvert.DeserializeObject<PaginatedAction>(result);
            //https://api.xivdb-staging.com/Action/7524?columns=ID,ActionCategory,ActionCombo,ActionProcStatus,ActionTimelineHit,AffectsPosition,Aspect,AttackType,CanTargetDead,CanTargetFriendly,CanTargetHostile,CanTargetParty,CanTargetSelf,CastType,ClassJobLevel,CooldownGroup,Cost,CostType,Description_en,EffectRange,Icon,IsPvP,IsRoleAction,Name_en,Omen,PreservesCombo,Range,Recast100ms,StatusGainSelf,Targetarea,UnlockLink

            Console.WriteLine("Done");
        }
    }
}
