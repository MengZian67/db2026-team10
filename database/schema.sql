USE [University]
GO
/****** Object:  Table [dbo].[advisor]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[advisor](
	[s_ID] [varchar](5) NOT NULL,
	[i_ID] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[s_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[classroom]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classroom](
	[building] [varchar](15) NOT NULL,
	[room_number] [varchar](7) NOT NULL,
	[capacity] [numeric](4, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[building] ASC,
	[room_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[course]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[course_id] [varchar](8) NOT NULL,
	[title] [varchar](50) NULL,
	[dept_name] [varchar](20) NULL,
	[credits] [numeric](2, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[dept_name] [varchar](20) NOT NULL,
	[building] [varchar](15) NULL,
	[budget] [numeric](12, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[dept_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[EnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [varchar](5) NULL,
	[CourseID] [varchar](10) NULL,
	[Semester] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[instructor]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instructor](
	[ID] [varchar](5) NOT NULL,
	[name] [varchar](20) NOT NULL,
	[dept_name] [varchar](20) NULL,
	[salary] [numeric](8, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prereq]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prereq](
	[course_id] [varchar](8) NOT NULL,
	[prereq_id] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[prereq_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[section]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[section](
	[course_id] [varchar](8) NOT NULL,
	[sec_id] [varchar](8) NOT NULL,
	[semester] [varchar](6) NOT NULL,
	[year] [numeric](4, 0) NOT NULL,
	[building] [varchar](15) NULL,
	[room_number] [varchar](7) NULL,
	[time_slot_id] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[sec_id] ASC,
	[semester] ASC,
	[year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[ID] [varchar](5) NOT NULL,
	[name] [nvarchar](20) NULL,
	[dept_name] [varchar](20) NULL,
	[tot_cred] [numeric](3, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[takes]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[takes](
	[ID] [varchar](5) NOT NULL,
	[course_id] [varchar](8) NOT NULL,
	[sec_id] [varchar](8) NOT NULL,
	[semester] [varchar](6) NOT NULL,
	[year] [numeric](4, 0) NOT NULL,
	[grade] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[course_id] ASC,
	[sec_id] ASC,
	[semester] ASC,
	[year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teaches]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teaches](
	[ID] [varchar](5) NOT NULL,
	[course_id] [varchar](8) NOT NULL,
	[sec_id] [varchar](8) NOT NULL,
	[semester] [varchar](6) NOT NULL,
	[year] [numeric](4, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[course_id] ASC,
	[sec_id] ASC,
	[semester] ASC,
	[year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[time_slot]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[time_slot](
	[time_slot_id] [varchar](4) NOT NULL,
	[day] [varchar](1) NOT NULL,
	[start_hr] [numeric](2, 0) NOT NULL,
	[start_min] [numeric](2, 0) NOT NULL,
	[end_hr] [numeric](2, 0) NULL,
	[end_min] [numeric](2, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[time_slot_id] ASC,
	[day] ASC,
	[start_hr] ASC,
	[start_min] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[ID] [int] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/20/2026 12:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[advisor]  WITH CHECK ADD FOREIGN KEY([i_ID])
REFERENCES [dbo].[instructor] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[advisor]  WITH CHECK ADD FOREIGN KEY([s_ID])
REFERENCES [dbo].[student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD FOREIGN KEY([dept_name])
REFERENCES [dbo].[department] ([dept_name])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[instructor]  WITH CHECK ADD FOREIGN KEY([dept_name])
REFERENCES [dbo].[department] ([dept_name])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[prereq]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([course_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[prereq]  WITH CHECK ADD FOREIGN KEY([prereq_id])
REFERENCES [dbo].[course] ([course_id])
GO
ALTER TABLE [dbo].[section]  WITH CHECK ADD FOREIGN KEY([building], [room_number])
REFERENCES [dbo].[classroom] ([building], [room_number])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[section]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([course_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[student]  WITH CHECK ADD FOREIGN KEY([dept_name])
REFERENCES [dbo].[department] ([dept_name])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[takes]  WITH CHECK ADD FOREIGN KEY([course_id], [sec_id], [semester], [year])
REFERENCES [dbo].[section] ([course_id], [sec_id], [semester], [year])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[takes]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[student] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[teaches]  WITH CHECK ADD FOREIGN KEY([course_id], [sec_id], [semester], [year])
REFERENCES [dbo].[section] ([course_id], [sec_id], [semester], [year])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[teaches]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[instructor] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD CHECK  (([credits]>(0)))
GO
ALTER TABLE [dbo].[department]  WITH CHECK ADD CHECK  (([budget]>(0)))
GO
ALTER TABLE [dbo].[instructor]  WITH CHECK ADD CHECK  (([salary]>(29000)))
GO
ALTER TABLE [dbo].[section]  WITH CHECK ADD CHECK  (([semester]='Summer' OR [semester]='Spring' OR [semester]='Winter' OR [semester]='Fall'))
GO
ALTER TABLE [dbo].[section]  WITH CHECK ADD CHECK  (([year]>(1701) AND [year]<(2100)))
GO
ALTER TABLE [dbo].[student]  WITH CHECK ADD CHECK  (([tot_cred]>=(0)))
GO
ALTER TABLE [dbo].[time_slot]  WITH CHECK ADD CHECK  (([end_hr]>=(0) AND [end_hr]<(24)))
GO
ALTER TABLE [dbo].[time_slot]  WITH CHECK ADD CHECK  (([end_min]>=(0) AND [end_min]<(60)))
GO
ALTER TABLE [dbo].[time_slot]  WITH CHECK ADD CHECK  (([start_hr]>=(0) AND [start_hr]<(24)))
GO
ALTER TABLE [dbo].[time_slot]  WITH CHECK ADD CHECK  (([start_min]>=(0) AND [start_min]<(60)))
GO
