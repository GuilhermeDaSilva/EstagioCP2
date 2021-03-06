USE [GradeHoraria]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[id_aula] [nchar](10) NOT NULL,
	[ano] [nvarchar](50) NOT NULL,
	[matricula_prof] [nvarchar](50) NULL,
	[turma] [nvarchar](50) NULL,
	[tempo] [int] NULL,
	[turno] [int] NULL,
	[dia_da_semana] [nvarchar](50) NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC,
	[ano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Disponibilidade]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidade](
	[id_disponibilidade] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [nvarchar](50) NOT NULL,
	[dia_da_semana] [nvarchar](50) NULL,
	[tempo_inicio] [int] NULL,
	[tempo_fim] [int] NULL,
	[turno] [int] NULL,
 CONSTRAINT [PK_Disponibilidade] PRIMARY KEY CLUSTERED 
(
	[id_disponibilidade] ASC,
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EscalaDeProva]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EscalaDeProva](
	[id_escala] [nchar](10) NOT NULL,
	[disciplina] [nvarchar](50) NULL,
	[matricula_prof] [nvarchar](50) NULL,
	[data] [date] NULL,
	[hora] [int] NULL,
	[ano] [nvarchar](50) NULL,
 CONSTRAINT [PK_EscalaDeProva_1] PRIMARY KEY CLUSTERED 
(
	[id_escala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GradeHTurma]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeHTurma](
	[turma] [nvarchar](50) NOT NULL,
	[ano] [nvarchar](50) NOT NULL,
	[matricula_prof] [nvarchar](50) NOT NULL,
	[dia_da_semana] [nvarchar](50) NOT NULL,
	[tempo] [int] NOT NULL,
	[turno] [int] NOT NULL,
 CONSTRAINT [PK_GradeH] PRIMARY KEY CLUSTERED 
(
	[turma] ASC,
	[ano] ASC,
	[matricula_prof] ASC,
	[dia_da_semana] ASC,
	[tempo] ASC,
	[turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professor]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[matricula] [nvarchar](50) NOT NULL,
	[nome] [nvarchar](50) NULL,
	[disciplina] [nvarchar](50) NULL,
	[carga_horaria] [int] NULL,
	[coordenador] [bit] NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RPS]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RPS](
	[id_rps] [int] IDENTITY(1,1) NOT NULL,
	[matricula_coord] [nvarchar](50) NULL,
	[disciplina] [nvarchar](50) NULL,
	[tempo] [int] NULL,
	[turno] [int] NULL,
	[dia_da_semana] [nvarchar](50) NULL,
 CONSTRAINT [PK_RPS] PRIMARY KEY CLUSTERED 
(
	[id_rps] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turma]    Script Date: 10/12/2018 12:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[turma] [nvarchar](50) NOT NULL,
	[ano] [nvarchar](50) NOT NULL,
	[turno] [int] NULL,
 CONSTRAINT [PK_Turma_1] PRIMARY KEY CLUSTERED 
(
	[turma] ASC,
	[ano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Disponibilidade]  WITH CHECK ADD  CONSTRAINT [FK_Disponibilidade_Professor] FOREIGN KEY([matricula])
REFERENCES [dbo].[Professor] ([matricula])
GO
ALTER TABLE [dbo].[Disponibilidade] CHECK CONSTRAINT [FK_Disponibilidade_Professor]
GO
ALTER TABLE [dbo].[EscalaDeProva]  WITH CHECK ADD  CONSTRAINT [FK_EscalaDeProva_Professor] FOREIGN KEY([matricula_prof])
REFERENCES [dbo].[Professor] ([matricula])
GO
ALTER TABLE [dbo].[EscalaDeProva] CHECK CONSTRAINT [FK_EscalaDeProva_Professor]
GO
ALTER TABLE [dbo].[RPS]  WITH CHECK ADD  CONSTRAINT [FK_RPS_Professor] FOREIGN KEY([matricula_coord])
REFERENCES [dbo].[Professor] ([matricula])
GO
ALTER TABLE [dbo].[RPS] CHECK CONSTRAINT [FK_RPS_Professor]
GO
