using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuOnline.Domain.Entities.Mu;

namespace MuOnline.EF.Mapping
{
    public class MembStatMap : IEntityTypeConfiguration<MembStat>
    {
        public void Configure(EntityTypeBuilder<MembStat> builder)
        {
            builder.ToTable("MEMB_STAT");
            builder.HasKey(x => x.memb___id);
            builder.Property(x => x.memb___id);
            builder.Property(x => x.ConnectStat); 
            builder.Property(x => x.ServerName); 
            builder.Property(x => x.IP); 
            builder.Property(x => x.ConnectTM); 
            builder.Property(x => x.DisConnectTM); 
        }
    }
}