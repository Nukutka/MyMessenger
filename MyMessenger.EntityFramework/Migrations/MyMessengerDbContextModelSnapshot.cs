﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMessenger.EntityFramework.DbContext;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

namespace MyMessenger.EntityFramework.Migrations
{
    [DbContext(typeof(MyMessengerDbContext))]
    partial class MyMessengerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MyMessenger.Domain.Entities.AssociativeEntities.UserChatAssociation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChatAssociations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000027"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000028"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000029"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000030"),
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        });
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Messaging.Attachment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Data")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("uuid");

                    b.Property<string>("MimeType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Messaging.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "27f6907bba0441338c2844d7a7966c2a",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Name = "Chat 1"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "cff3b1cf6db44236a99873db1defe002",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            Name = "Chat 2"
                        });
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Messaging.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            Body = "Message 1",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "97acdabfcbf14b1681d81af65831238e",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            Body = "Message 2",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "ae171adf37db40f5a2e7af2272fab979",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            Body = "Message 3",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "edb2927214e84f37ae618b0aa38d1a8d",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            Body = "Message 4",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "3328b25bae6e4f16bcb3899c83e5950f",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000011"),
                            Body = "Message 5",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "1203a5fdeeed45838c71d118d685a91e",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000012"),
                            Body = "Message 6",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "0149b859c63a4fe19abe04bbeba5ebfd",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000013"),
                            Body = "Message 7",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "d1a4b54325d04b619eb7466d4b4520fe",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000014"),
                            Body = "Message 8",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "b1edf39ea8764681addbf1df87b8d08d",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000015"),
                            Body = "Message 9",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "3011bfa843c14c24a9a87333467b2ed7",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000016"),
                            Body = "Message 10",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "b790448781c84f53887ec118bbb80655",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000017"),
                            Body = "Message 11",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "f159752ec2454b129a5b5ff3f03aca40",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000018"),
                            Body = "Message 12",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "60b703620c4b48b3b065eebcf30f49a4",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000019"),
                            Body = "Message 13",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "5c8ff68b14d048df850cd48938afa93f",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000020"),
                            Body = "Message 14",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "3c3c51e6c03b479781b71565ca50186f",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000021"),
                            Body = "Message 15",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "049e89082a884558b78fd84b307475c2",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000022"),
                            Body = "Message 16",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "908fd2140f6c4b5794bb5c98e119c9b3",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000023"),
                            Body = "Message 17",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "78e58195318c499ca048420e846f80fa",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000024"),
                            Body = "Message 18",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "23787a5ab19740e895d29fb682b995e7",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000025"),
                            Body = "Message 19",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "ecc5c4cd45db4fcd9490737212c7cf07",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000026"),
                            Body = "Message 20",
                            ChatId = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "ffbb6e42934840e4b8413fe8553a1e69",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        });
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("text");

                    b.Property<string>("HashPassword")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ConcurrencyStamp = "27e66d61f9c7477595ef8f973a4bdebd",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            HashPassword = "6298AA0670BFE6313A68AD4F3B4E82845C9CACE4D9CAD1B5883FF4BCE6B53AB84FC5C0191AACFC1FF650E45B673D014B67708AEA9FB5620287E703D95DA77BFB",
                            Login = "user1"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            ConcurrencyStamp = "9e3abf41077d4bc4b243c41049ffea49",
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ExtraProperties = "{}",
                            HashPassword = "9A0E11B587FCBD3D236C80BBF8E43A59AC122CED771EBAB6EA54E579DEAB0DB8DF2EC592EDBE70EB6DFFD6B8834E2B3682E39F183DFCA53E01939348B4D519EC",
                            Login = "user2"
                        });
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Users.UserInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("ActiveStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("uuid");

                    b.Property<string>("Lastname")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInfos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            ActiveStatus = 1,
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@test.com",
                            Firstname = "Nikita",
                            Lastname = "Nagovitsyn",
                            UserId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            ActiveStatus = 1,
                            CreationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test2@test.com",
                            Firstname = "Darya",
                            Lastname = "Shigabytdinova",
                            UserId = new Guid("00000000-0000-0000-0000-000000000003")
                        });
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.AssociativeEntities.UserChatAssociation", b =>
                {
                    b.HasOne("MyMessenger.Domain.Entities.Messaging.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMessenger.Domain.Entities.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Messaging.Attachment", b =>
                {
                    b.HasOne("MyMessenger.Domain.Entities.Messaging.Message", null)
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Messaging.Message", b =>
                {
                    b.HasOne("MyMessenger.Domain.Entities.Messaging.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMessenger.Domain.Entities.Users.UserInfo", b =>
                {
                    b.HasOne("MyMessenger.Domain.Entities.Users.User", null)
                        .WithOne("UserInfo")
                        .HasForeignKey("MyMessenger.Domain.Entities.Users.UserInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
