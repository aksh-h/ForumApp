/****** Object:  Database [ForumDB]    Script Date: 01-03-2020 18:13:38 ******/
CREATE DATABASE [ForumDB]
GO


CREATE TABLE [dbo].[Questions](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NULL,
	[Discription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[IsEnable] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reply]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reply](
	[ReplyID] [int] IDENTITY(1,1) NOT NULL,
	[Reply] [nvarchar](max) NOT NULL,
	[IsEnable] [bit] NULL,
	[QuestionID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReplyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (1, N'How are you?', N'Just asking yar', CAST(N'2020-02-29T21:26:35.160' AS DateTime), NULL, 0)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (2, N'Had dinner?', N'Ok', CAST(N'2020-02-29T23:14:48.023' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (3, N'Test Forum ques', N'Testing', CAST(N'2020-02-29T23:17:19.280' AS DateTime), NULL, 0)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (4, N'Hello', N'Hi', CAST(N'2020-02-29T23:17:53.743' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (5, N'Tata', N'bye', CAST(N'2020-02-29T23:18:18.393' AS DateTime), NULL, 0)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (6, N'Akshatha', N'Akshatha', CAST(N'2020-03-01T00:08:25.623' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (7, N'Sleeping?', N'About you', CAST(N'2020-03-01T00:15:50.927' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (8, N'What are you doing?', N'', CAST(N'2020-03-01T00:16:55.520' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (9, N'Lunch ??', N'', CAST(N'2020-03-01T00:18:16.353' AS DateTime), NULL, 1)
GO
INSERT [dbo].[Questions] ([QuestionID], [Question], [Discription], [CreatedDate], [UpdatedDate], [IsEnable]) VALUES (10, N'Test@123', N'Test', CAST(N'2020-03-01T12:38:50.617' AS DateTime), NULL, 0)
GO
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[Reply] ON 

GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (1, N'How about you? Are you there??', 1, 1, CAST(N'2020-02-29T21:47:38.917' AS DateTime), CAST(N'2020-02-29T21:50:49.317' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (2, N'what are you doing?', 1, 1, CAST(N'2020-03-01T13:39:28.347' AS DateTime), NULL)
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (3, N'yes, yours?', 0, 2, CAST(N'2020-03-01T16:36:39.940' AS DateTime), CAST(N'2020-03-01T18:05:25.480' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (4, N'ok', 0, 2, CAST(N'2020-03-01T16:38:49.697' AS DateTime), CAST(N'2020-03-01T17:36:35.837' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (5, N'yjy', 0, 2, CAST(N'2020-03-01T16:41:01.453' AS DateTime), CAST(N'2020-03-01T17:42:39.673' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (6, N'ok', 0, 2, CAST(N'2020-03-01T16:43:00.097' AS DateTime), CAST(N'2020-03-01T17:38:54.677' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (7, N'a,sn', 0, 2, CAST(N'2020-03-01T16:56:02.070' AS DateTime), CAST(N'2020-03-01T17:41:14.440' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (8, N'asdasd', 0, 2, CAST(N'2020-03-01T16:56:48.303' AS DateTime), CAST(N'2020-03-01T17:41:17.420' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (9, N'asdasd', 0, 2, CAST(N'2020-03-01T16:57:01.307' AS DateTime), CAST(N'2020-03-01T17:42:42.633' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (10, N'Hi, how are you? Ok', 1, 4, CAST(N'2020-03-01T17:00:22.220' AS DateTime), CAST(N'2020-03-01T18:02:59.627' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (11, N'whats up?', 1, 4, CAST(N'2020-03-01T17:01:24.137' AS DateTime), NULL)
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (12, N'Ya', 0, 6, CAST(N'2020-03-01T17:43:05.113' AS DateTime), CAST(N'2020-03-01T17:43:13.697' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (13, N'Ya', 0, 6, CAST(N'2020-03-01T17:44:27.030' AS DateTime), CAST(N'2020-03-01T17:44:53.287' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (14, N'ya', 0, 6, CAST(N'2020-03-01T17:45:32.877' AS DateTime), CAST(N'2020-03-01T17:47:06.667' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (15, N'no', 0, 7, CAST(N'2020-03-01T17:48:59.750' AS DateTime), CAST(N'2020-03-01T17:49:14.963' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (16, N'no', 0, 6, CAST(N'2020-03-01T17:50:09.197' AS DateTime), CAST(N'2020-03-01T17:50:12.790' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (17, N'No :)', 0, 2, CAST(N'2020-03-01T18:05:33.433' AS DateTime), CAST(N'2020-03-01T18:07:15.910' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (18, N'Hey, okay', 0, 2, CAST(N'2020-03-01T18:07:09.417' AS DateTime), CAST(N'2020-03-01T18:07:50.740' AS DateTime))
GO
INSERT [dbo].[Reply] ([ReplyID], [Reply], [IsEnable], [QuestionID], [CreatedDate], [ModifiedDate]) VALUES (19, N'No', 0, 2, CAST(N'2020-03-01T18:07:30.317' AS DateTime), CAST(N'2020-03-01T18:07:48.380' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Reply] OFF
GO
ALTER TABLE [dbo].[Reply]  WITH CHECK ADD FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([QuestionID])
GO
/****** Object:  StoredProcedure [dbo].[DeleteQuestion]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteQuestion](
@QuestionID int
)
as
BEGIN
	Update Questions
	set IsEnable = 0
	where QuestionID = @QuestionID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteReply]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteReply](
@ReplyID int
)
as
BEGIN
	update Reply
	set IsEnable = 0, ModifiedDate = CURRENT_TIMESTAMP
	where ReplyID = @ReplyID
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllQuestions]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllQuestions]
as
BEGIN
	select * from Questions
	where IsEnable = 1
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllReplies]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllReplies](
@QuestionID int
)
as
BEGIN
	select * from Reply
	where QuestionID = @QuestionID and IsEnable = 1
END
GO
/****** Object:  StoredProcedure [dbo].[GetAReply]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAReply]
@ReplyId int
as
begin
	select * from Reply
	where ReplyID = @ReplyId and IsEnable = 1

end
GO
/****** Object:  StoredProcedure [dbo].[GetQuestion]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetQuestion](
@QuestionID int
)
as
Begin
	select * from Questions
	where IsEnable =1 and QuestionID = @QuestionID
end
GO
/****** Object:  StoredProcedure [dbo].[GetReplyForAQuestions]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec GetReplyForAQuestions @QuestionID= 1
CREATE proc [dbo].[GetReplyForAQuestions]
@QuestionID int
as
begin
	select q.Question, q.Discription, q.QuestionID, r.Reply, r.ReplyID from Reply as r
	right join Questions as q on r.QuestionID = q.QuestionID
	where q.QuestionID = @QuestionID and r.IsEnable = 1
end

	 
GO
/****** Object:  StoredProcedure [dbo].[GetReplyToAllQuestions]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetReplyToAllQuestions]
as
begin
	select q.Question, q.Discription, q.QuestionID, r.Reply, r.ReplyID from Reply as r
	right join Questions as q on r.QuestionID = q.QuestionID
end
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoQuestions]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec InsertIntoQuestions @Question = 'How are you?',@Discription = 'Just asking ye!!'

CREATE proc [dbo].[InsertIntoQuestions](
@Question nvarchar(max),
@Discription nvarchar(max)
)
as
begin
declare @CreatedDate datetime =  CURRENT_TIMESTAMP
insert into Questions (Question, Discription, CreatedDate,IsEnable)
values (@Question, @Discription,CURRENT_TIMESTAMP, 1)
end



GO
/****** Object:  StoredProcedure [dbo].[InsertIntoReply]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec [InsertIntoReply] @QuestionID = 1,@Reply ='what are you doing?'
CREATE proc [dbo].[InsertIntoReply](
@QuestionID int,
@Reply nvarchar(max)
)
as
BEGIN
	insert into Reply ([Reply],[QuestionID],[IsEnable],[CreatedDate])
	values(@Reply,@QuestionID, 1, CURRENT_TIMESTAMP)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuestion]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateQuestion](
@QuestionID int,
@Question nvarchar(max),
@Discription nvarchar(max)
)
as
BEGIN
	Update Questions
	set Question = @Question, Discription = @Discription
	where QuestionID = @QuestionID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateReply]    Script Date: 01-03-2020 18:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC UpdateReply @ReplyID = 1, @Reply = 'How about you? Are you there??'

CREATE proc [dbo].[UpdateReply](
@Reply nvarchar(max),
@ReplyID int
)
as
BEGIN
	update Reply
	set Reply = @Reply, ModifiedDate = CURRENT_TIMESTAMP
	where ReplyID = @ReplyID
END


GO
USE [master]
GO
ALTER DATABASE [ForumDB] SET  READ_WRITE 
GO
