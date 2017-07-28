using System.Data.Entity;

namespace Fluxy.Data.Initilizers
{
    public  class FluxyDBInitializer: DropCreateDatabaseAlways<FluxyContext>
    {
        protected override void Seed(FluxyContext context)
        {
            base.Seed(context);
        }
    }
}
