using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MuOnline.Domain.Entities.Mu;

namespace MuOnline.EF.Mapping
{
    public class MembInfoMap : IEntityTypeConfiguration<MembInfo>
    {
        public void Configure(EntityTypeBuilder<MembInfo> builder)
        {
            builder.ToTable("MEMB_INFO");
            builder.HasKey(x => x.memb_guid);
            builder.Property(x => x.memb_guid);
            builder.Property(x => x.memb_guid);
            builder.Property(x => x.memb___id);
            builder.Property(x => x.memb__pwd);
            builder.Property(x => x.memb_name);
            builder.Property(x => x.sno__numb);
            builder.Property(x => x.post_code);
            builder.Property(x => x.addr_info);
            builder.Property(x => x.addr_deta);
            builder.Property(x => x.tel__numb);
            builder.Property(x => x.phon_numb);
            builder.Property(x => x.mail_addr);
            builder.Property(x => x.fpas_ques);
            builder.Property(x => x.fpas_answ);
            builder.Property(x => x.job__code);
            builder.Property(x => x.appl_days);
            builder.Property(x => x.modi_days);
            builder.Property(x => x.out__days);
            builder.Property(x => x.true_days);
            builder.Property(x => x.mail_chek);
            builder.Property(x => x.bloc_code);
            builder.Property(x => x.ctl1_code);
            builder.Property(x => x.cspoints);
            builder.Property(x => x.VipType);
            builder.Property(x => x.VipStart);
            builder.Property(x => x.VipDays);
            builder.Property(x => x.JoinDate);
        }
    }
}