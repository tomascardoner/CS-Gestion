USE [CSGestion]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Banco](
	[IdBanco] [smallint] NOT NULL,
	[Codigo] [char](3) NULL,
	[Nombre] [varchar](100) NOT NULL,
	[CUIT] [char](11) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Banco] PRIMARY KEY CLUSTERED 
(
	[IdBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BancoSucursal]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BancoSucursal](
	[IdBanco] [smallint] NOT NULL,
	[IdSucursal] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__BancoSucursal] PRIMARY KEY CLUSTERED 
(
	[IdBanco] ASC,
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cheque]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cheque](
	[IdEntidad] [int] NOT NULL,
	[IdCheque] [int] NOT NULL,
	[IdCuentaBancaria] [tinyint] NOT NULL,
	[IdChequeTalonario] [smallint] NOT NULL,
	[Numero] [int] NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[FechaPago] [date] NULL,
	[Importe] [money] NOT NULL,
	[LibradoA] [varchar](100) NULL,
	[NoALaOrden] [bit] NOT NULL,
	[Referencia] [varchar](20) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Cheque] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdCheque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChequeTalonario]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChequeTalonario](
	[IdEntidad] [int] NOT NULL,
	[IdCuentaBancaria] [tinyint] NOT NULL,
	[IdChequeTalonario] [smallint] NOT NULL,
	[IdChequeTalonarioTipo] [tinyint] NOT NULL,
	[Serie] [varchar](2) NULL,
	[NumeroInicio] [int] NULL,
	[NumeroFin] [int] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_ChequeTalonario] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdCuentaBancaria] ASC,
	[IdChequeTalonario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChequeTalonarioTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChequeTalonarioTipo](
	[IdChequeTalonarioTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[UtilizaFechaPago] [bit] NOT NULL,
	[PlazoMaximoDias] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__ChequeTalonarioTipo] PRIMARY KEY CLUSTERED 
(
	[IdChequeTalonarioTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaBancariaTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentaBancariaTipo](
	[IdCuentaBancariaTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[IdMoneda] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CuentaBancariaTipo] PRIMARY KEY CLUSTERED 
(
	[IdCuentaBancariaTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocumentoTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentoTipo](
	[IdDocumentoTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[VerificaModulo11] [bit] NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__DocumentoTipo] PRIMARY KEY CLUSTERED 
(
	[IdDocumentoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DomicilioTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DomicilioTipo](
	[IdDomicilioTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__DomicilioTipo] PRIMARY KEY CLUSTERED 
(
	[IdDomicilioTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmailTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmailTipo](
	[IdEmailTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EmailTipo] PRIMARY KEY CLUSTERED 
(
	[IdEmailTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [tinyint] NOT NULL,
	[RazonSocial] [varchar](150) NOT NULL,
	[Cuit] [char](11) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entidad]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entidad](
	[IdEntidad] [int] NOT NULL,
	[EsPersonaFisica] [bit] NOT NULL,
	[RazonSocial] [varchar](150) NULL,
	[NombreFantasia] [varchar](150) NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[NombreParaMostrar]  AS (case when [NombreFantasia] IS NULL then case when [RazonSocial] IS NULL then case when [Apellido] IS NULL then isnull([Nombre],'') else [Apellido]+case when [Nombre] IS NULL then '' else ', '+[Nombre] end end else [RazonSocial] end else [NombreFantasia] end),
	[Cuit] [char](11) NULL,
	[IngresosBrutos] [varchar](12) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Entidad] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntidadCuentaBancaria]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntidadCuentaBancaria](
	[IdEntidad] [int] NOT NULL,
	[IdCuentaBancaria] [tinyint] NOT NULL,
	[IdBanco] [smallint] NOT NULL,
	[IdCuentaBancariaTipo] [tinyint] NOT NULL,
	[Sucursal] [smallint] NULL,
	[Numero] [varchar](20) NULL,
	[Cbu] [char](22) NULL,
	[CbuAlias] [varchar](20) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EntidadCuentaBancaria] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdCuentaBancaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntidadDomicilio]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntidadDomicilio](
	[IdEntidad] [int] NOT NULL,
	[IdDomicilio] [tinyint] NOT NULL,
	[IdDomicilioTipo] [tinyint] NOT NULL,
	[TipoOtro] [varchar](50) NULL,
	[Calle1] [varchar](100) NULL,
	[Numero] [varchar](10) NULL,
	[Piso] [varchar](10) NULL,
	[Departamento] [varchar](10) NULL,
	[Calle2] [varchar](50) NULL,
	[Calle3] [varchar](50) NULL,
	[DomicilioParaMostrar]  AS ([dbo].[udf_GetDomicilioCalleCompleto]([Calle1],[Numero],[Piso],[Departamento],[Calle2],[Calle3])),
	[CodigoPostal] [varchar](8) NULL,
	[IdProvincia] [tinyint] NULL,
	[IdLocalidad] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EntidadDomicilio] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdDomicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntidadEmail]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntidadEmail](
	[IdEntidad] [int] NOT NULL,
	[IdEmail] [tinyint] NOT NULL,
	[IdEmailTipo] [tinyint] NOT NULL,
	[TipoOtro] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EntidadEmail] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntidadEmpresa]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadEmpresa](
	[IdEntidad] [int] NOT NULL,
	[IdEmpresa] [tinyint] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EntidadEmpresa] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EntidadTelefono]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntidadTelefono](
	[IdEntidad] [int] NOT NULL,
	[IdTelefono] [tinyint] NOT NULL,
	[IdTelefonoTipo] [tinyint] NOT NULL,
	[TipoOtro] [varchar](50) NULL,
	[CodigoPais] [tinyint] NULL,
	[CodigoArea] [smallint] NULL,
	[Numero] [int] NOT NULL,
	[Interno] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__EntidadTelefono] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC,
	[IdTelefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdProvincia] [tinyint] NOT NULL,
	[IdLocalidad] [smallint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[CodigoPostal] [char](4) NULL,
 CONSTRAINT [PK__Localidad] PRIMARY KEY NONCLUSTERED 
(
	[IdProvincia] ASC,
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Moneda](
	[IdMoneda] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Simbolo] [varchar](10) NULL,
	[CodigoAFIP] [char](3) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL CONSTRAINT [DF_Moneda_IDUsuarioCreacion]  DEFAULT ((1)),
	[FechaHoraCreacion] [smalldatetime] NOT NULL CONSTRAINT [DF_Moneda_FechaHoraCreacion]  DEFAULT (getdate()),
	[IdUsuarioModificacion] [smallint] NOT NULL CONSTRAINT [DF_Moneda_IDUsuarioModificacion]  DEFAULT ((1)),
	[FechaHoraModificacion] [smalldatetime] NOT NULL CONSTRAINT [DF_Moneda_FechaHoraModificacion]  DEFAULT (getdate()),
 CONSTRAINT [PK__Moneda] PRIMARY KEY CLUSTERED 
(
	[IdMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdEmpresa] [tinyint] NOT NULL,
	[IdMovimiento] [int] NOT NULL,
	[IdMovimientoTipo] [tinyint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[IdEntidad] [int] NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[ImporteNeto] [money] NOT NULL,
	[ImporteImpuesto] [money] NOT NULL,
	[ImporteTotal] [money] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Movimiento] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MovimientoAplicacion]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientoAplicacion](
	[IdEmpresa] [tinyint] NOT NULL,
	[IdMovimiento] [int] NOT NULL,
	[IdMovimientoAplicado] [int] NOT NULL,
	[ImporteAplicado] [money] NOT NULL,
 CONSTRAINT [PK__MovimientoAplicacion] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdMovimiento] ASC,
	[IdMovimientoAplicado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovimientoTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MovimientoTipo](
	[IdMovimientoTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[GeneraDebito] [bit] NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__MovimientoTipo] PRIMARY KEY CLUSTERED 
(
	[IdMovimientoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parametro](
	[IdParametro] [char](100) NOT NULL,
	[Texto] [varchar](max) NULL,
	[NumeroEntero] [int] NULL,
	[NumeroDecimal] [decimal](18, 9) NULL,
	[Moneda] [money] NULL,
	[FechaHora] [smalldatetime] NULL,
	[SiNo] [bit] NULL,
	[Notas] [varchar](max) NULL,
 CONSTRAINT [PK__Parametro] PRIMARY KEY CLUSTERED 
(
	[IdParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[IdProvincia] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Provincia] PRIMARY KEY NONCLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TelefonoTipo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TelefonoTipo](
	[IdTelefonoTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__TelefonoTipo] PRIMARY KEY CLUSTERED 
(
	[IdTelefonoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Genero] [char](1) NOT NULL,
	[IdUsuarioGrupo] [tinyint] NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioGrupo]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioGrupo](
	[IdUsuarioGrupo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IdUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IdUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__UsuarioGrupo] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioGrupoPermiso]    Script Date: 31/12/2019 17:18:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioGrupoPermiso](
	[IdUsuarioGrupo] [tinyint] NOT NULL,
	[IdPermiso] [char](100) NOT NULL,
 CONSTRAINT [PK__UsuarioGrupoPermiso] PRIMARY KEY CLUSTERED 
(
	[IdUsuarioGrupo] ASC,
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[EntidadEmpresa] ADD  CONSTRAINT [DF_EntidadEmpresa_IdUsuarioCreacion]  DEFAULT ((1)) FOR [IdUsuarioCreacion]
GO
ALTER TABLE [dbo].[EntidadEmpresa] ADD  CONSTRAINT [DF_EntidadEmpresa_FechaHoraCreacion]  DEFAULT (getdate()) FOR [FechaHoraCreacion]
GO
ALTER TABLE [dbo].[Banco]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Banco__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Banco] CHECK CONSTRAINT [FK__Usuario__Banco__Creacion]
GO
ALTER TABLE [dbo].[Banco]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Banco__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Banco] CHECK CONSTRAINT [FK__Usuario__Banco__Modificacion]
GO
ALTER TABLE [dbo].[BancoSucursal]  WITH CHECK ADD  CONSTRAINT [FK__Banco__BancoSucursal] FOREIGN KEY([IdBanco])
REFERENCES [dbo].[Banco] ([IdBanco])
GO
ALTER TABLE [dbo].[BancoSucursal] CHECK CONSTRAINT [FK__Banco__BancoSucursal]
GO
ALTER TABLE [dbo].[BancoSucursal]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__BancoSucursal__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[BancoSucursal] CHECK CONSTRAINT [FK__Usuario__BancoSucursal__Creacion]
GO
ALTER TABLE [dbo].[BancoSucursal]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__BancoSucursal__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[BancoSucursal] CHECK CONSTRAINT [FK__Usuario__BancoSucursal__Modificacion]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cheque__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK__Usuario__Cheque__Creacion]
GO
ALTER TABLE [dbo].[Cheque]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cheque__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Cheque] CHECK CONSTRAINT [FK__Usuario__Cheque__Modificacion]
GO
ALTER TABLE [dbo].[ChequeTalonario]  WITH CHECK ADD  CONSTRAINT [FK__ChequeTalonarioTipo__ChequeTalonario] FOREIGN KEY([IdChequeTalonarioTipo])
REFERENCES [dbo].[ChequeTalonarioTipo] ([IdChequeTalonarioTipo])
GO
ALTER TABLE [dbo].[ChequeTalonario] CHECK CONSTRAINT [FK__ChequeTalonarioTipo__ChequeTalonario]
GO
ALTER TABLE [dbo].[ChequeTalonario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ChequeTalonario__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ChequeTalonario] CHECK CONSTRAINT [FK__Usuario__ChequeTalonario__Creacion]
GO
ALTER TABLE [dbo].[ChequeTalonario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ChequeTalonario__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ChequeTalonario] CHECK CONSTRAINT [FK__Usuario__ChequeTalonario__Modificacion]
GO
ALTER TABLE [dbo].[ChequeTalonarioTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ChequeTalonarioTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ChequeTalonarioTipo] CHECK CONSTRAINT [FK__Usuario__ChequeTalonarioTipo__Creacion]
GO
ALTER TABLE [dbo].[ChequeTalonarioTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ChequeTalonarioTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ChequeTalonarioTipo] CHECK CONSTRAINT [FK__Usuario__ChequeTalonarioTipo__Modificacion]
GO
ALTER TABLE [dbo].[CuentaBancariaTipo]  WITH CHECK ADD  CONSTRAINT [FK__Moneda__CuentaBancariaTipo] FOREIGN KEY([IdMoneda])
REFERENCES [dbo].[Moneda] ([IdMoneda])
GO
ALTER TABLE [dbo].[CuentaBancariaTipo] CHECK CONSTRAINT [FK__Moneda__CuentaBancariaTipo]
GO
ALTER TABLE [dbo].[CuentaBancariaTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CuentaBancariaTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[CuentaBancariaTipo] CHECK CONSTRAINT [FK__Usuario__CuentaBancariaTipo__Creacion]
GO
ALTER TABLE [dbo].[CuentaBancariaTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CuentaBancariaTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[CuentaBancariaTipo] CHECK CONSTRAINT [FK__Usuario__CuentaBancariaTipo__Modificacion]
GO
ALTER TABLE [dbo].[DocumentoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DocumentoTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[DocumentoTipo] CHECK CONSTRAINT [FK__Usuario__DocumentoTipo__Creacion]
GO
ALTER TABLE [dbo].[DocumentoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DocumentoTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[DocumentoTipo] CHECK CONSTRAINT [FK__Usuario__DocumentoTipo__Modificacion]
GO
ALTER TABLE [dbo].[DomicilioTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DomicilioTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[DomicilioTipo] CHECK CONSTRAINT [FK__Usuario__DomicilioTipo__Creacion]
GO
ALTER TABLE [dbo].[DomicilioTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DomicilioTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[DomicilioTipo] CHECK CONSTRAINT [FK__Usuario__DomicilioTipo__Modificacion]
GO
ALTER TABLE [dbo].[EmailTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EmailTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EmailTipo] CHECK CONSTRAINT [FK__Usuario__EmailTipo__Creacion]
GO
ALTER TABLE [dbo].[EmailTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EmailTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EmailTipo] CHECK CONSTRAINT [FK__Usuario__EmailTipo__Modificacion]
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Empresa__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK__Usuario__Empresa__Creacion]
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Empresa__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK__Usuario__Empresa__Modificacion]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Entidad__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK__Usuario__Entidad__Creacion]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Entidad__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK__Usuario__Entidad__Modificacion]
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria]  WITH CHECK ADD  CONSTRAINT [FK__Entidad__EntidadCuentaBancaria] FOREIGN KEY([IdEntidad])
REFERENCES [dbo].[Entidad] ([IdEntidad])
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria] CHECK CONSTRAINT [FK__Entidad__EntidadCuentaBancaria]
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadCuentaBancaria__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria] CHECK CONSTRAINT [FK__Usuario__EntidadCuentaBancaria__Creacion]
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadCuentaBancaria__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadCuentaBancaria] CHECK CONSTRAINT [FK__Usuario__EntidadCuentaBancaria__Modificacion]
GO
ALTER TABLE [dbo].[EntidadDomicilio]  WITH CHECK ADD  CONSTRAINT [FK__DomicilioTipo__EntidadDomicilio] FOREIGN KEY([IdDomicilioTipo])
REFERENCES [dbo].[DomicilioTipo] ([IdDomicilioTipo])
GO
ALTER TABLE [dbo].[EntidadDomicilio] CHECK CONSTRAINT [FK__DomicilioTipo__EntidadDomicilio]
GO
ALTER TABLE [dbo].[EntidadDomicilio]  WITH CHECK ADD  CONSTRAINT [FK__Entidad__EntidadDomicilio] FOREIGN KEY([IdEntidad])
REFERENCES [dbo].[Entidad] ([IdEntidad])
GO
ALTER TABLE [dbo].[EntidadDomicilio] CHECK CONSTRAINT [FK__Entidad__EntidadDomicilio]
GO
ALTER TABLE [dbo].[EntidadDomicilio]  WITH CHECK ADD  CONSTRAINT [FK__Localidad__EntidadDomicilio] FOREIGN KEY([IdProvincia], [IdLocalidad])
REFERENCES [dbo].[Localidad] ([IdProvincia], [IdLocalidad])
GO
ALTER TABLE [dbo].[EntidadDomicilio] CHECK CONSTRAINT [FK__Localidad__EntidadDomicilio]
GO
ALTER TABLE [dbo].[EntidadDomicilio]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadDomicilio__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadDomicilio] CHECK CONSTRAINT [FK__Usuario__EntidadDomicilio__Creacion]
GO
ALTER TABLE [dbo].[EntidadDomicilio]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadDomicilio__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadDomicilio] CHECK CONSTRAINT [FK__Usuario__EntidadDomicilio__Modificacion]
GO
ALTER TABLE [dbo].[EntidadEmail]  WITH CHECK ADD  CONSTRAINT [FK__EmailTipo__EntidadEmail] FOREIGN KEY([IdEmailTipo])
REFERENCES [dbo].[EmailTipo] ([IdEmailTipo])
GO
ALTER TABLE [dbo].[EntidadEmail] CHECK CONSTRAINT [FK__EmailTipo__EntidadEmail]
GO
ALTER TABLE [dbo].[EntidadEmail]  WITH CHECK ADD  CONSTRAINT [FK__Entidad__EntidadEmail] FOREIGN KEY([IdEntidad])
REFERENCES [dbo].[Entidad] ([IdEntidad])
GO
ALTER TABLE [dbo].[EntidadEmail] CHECK CONSTRAINT [FK__Entidad__EntidadEmail]
GO
ALTER TABLE [dbo].[EntidadEmail]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadEmail__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadEmail] CHECK CONSTRAINT [FK__Usuario__EntidadEmail__Creacion]
GO
ALTER TABLE [dbo].[EntidadEmail]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadEmail__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadEmail] CHECK CONSTRAINT [FK__Usuario__EntidadEmail__Modificacion]
GO
ALTER TABLE [dbo].[EntidadEmpresa]  WITH CHECK ADD  CONSTRAINT [FK__Empresa__EntidadEmpresa] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[EntidadEmpresa] CHECK CONSTRAINT [FK__Empresa__EntidadEmpresa]
GO
ALTER TABLE [dbo].[EntidadEmpresa]  WITH CHECK ADD  CONSTRAINT [FK__Entidad__EntidadEmpresa] FOREIGN KEY([IdEntidad])
REFERENCES [dbo].[Entidad] ([IdEntidad])
GO
ALTER TABLE [dbo].[EntidadEmpresa] CHECK CONSTRAINT [FK__Entidad__EntidadEmpresa]
GO
ALTER TABLE [dbo].[EntidadEmpresa]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadEmpresa] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadEmpresa] CHECK CONSTRAINT [FK__Usuario__EntidadEmpresa]
GO
ALTER TABLE [dbo].[EntidadTelefono]  WITH CHECK ADD  CONSTRAINT [FK__Entidad__EntidadTelefono] FOREIGN KEY([IdEntidad])
REFERENCES [dbo].[Entidad] ([IdEntidad])
GO
ALTER TABLE [dbo].[EntidadTelefono] CHECK CONSTRAINT [FK__Entidad__EntidadTelefono]
GO
ALTER TABLE [dbo].[EntidadTelefono]  WITH CHECK ADD  CONSTRAINT [FK__TelefonoTipo__EntidadTelefono] FOREIGN KEY([IdTelefonoTipo])
REFERENCES [dbo].[TelefonoTipo] ([IdTelefonoTipo])
GO
ALTER TABLE [dbo].[EntidadTelefono] CHECK CONSTRAINT [FK__TelefonoTipo__EntidadTelefono]
GO
ALTER TABLE [dbo].[EntidadTelefono]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadTelefono__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadTelefono] CHECK CONSTRAINT [FK__Usuario__EntidadTelefono__Creacion]
GO
ALTER TABLE [dbo].[EntidadTelefono]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__EntidadTelefono__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[EntidadTelefono] CHECK CONSTRAINT [FK__Usuario__EntidadTelefono__Modificacion]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK__Provincia__Localidad] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincia] ([IdProvincia])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK__Provincia__Localidad]
GO
ALTER TABLE [dbo].[Moneda]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Moneda__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Moneda] CHECK CONSTRAINT [FK__Usuario__Moneda__Creacion]
GO
ALTER TABLE [dbo].[Moneda]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Moneda__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Moneda] CHECK CONSTRAINT [FK__Usuario__Moneda__Modificacion]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK__Empresa__Movimiento] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresa] ([IdEmpresa])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK__Empresa__Movimiento]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK__MovimientoTipo__Movimiento] FOREIGN KEY([IdMovimientoTipo])
REFERENCES [dbo].[MovimientoTipo] ([IdMovimientoTipo])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK__MovimientoTipo__Movimiento]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Movimiento__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK__Usuario__Movimiento__Creacion]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Movimiento__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [FK__Usuario__Movimiento__Modificacion]
GO
ALTER TABLE [dbo].[MovimientoAplicacion]  WITH CHECK ADD  CONSTRAINT [FK__Movimiento__MovimientoAplicacion__Aplicado] FOREIGN KEY([IdEmpresa], [IdMovimientoAplicado])
REFERENCES [dbo].[Movimiento] ([IdEmpresa], [IdMovimiento])
GO
ALTER TABLE [dbo].[MovimientoAplicacion] CHECK CONSTRAINT [FK__Movimiento__MovimientoAplicacion__Aplicado]
GO
ALTER TABLE [dbo].[MovimientoAplicacion]  WITH CHECK ADD  CONSTRAINT [FK__Movimiento__MovimientoAplicacion_Aplicante] FOREIGN KEY([IdEmpresa], [IdMovimiento])
REFERENCES [dbo].[Movimiento] ([IdEmpresa], [IdMovimiento])
GO
ALTER TABLE [dbo].[MovimientoAplicacion] CHECK CONSTRAINT [FK__Movimiento__MovimientoAplicacion_Aplicante]
GO
ALTER TABLE [dbo].[MovimientoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__MovimientoTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[MovimientoTipo] CHECK CONSTRAINT [FK__Usuario__MovimientoTipo__Creacion]
GO
ALTER TABLE [dbo].[MovimientoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__MovimientoTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[MovimientoTipo] CHECK CONSTRAINT [FK__Usuario__MovimientoTipo__Modificacion]
GO
ALTER TABLE [dbo].[TelefonoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__TelefonoTipo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[TelefonoTipo] CHECK CONSTRAINT [FK__Usuario__TelefonoTipo__Creacion]
GO
ALTER TABLE [dbo].[TelefonoTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__TelefonoTipo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[TelefonoTipo] CHECK CONSTRAINT [FK__Usuario__TelefonoTipo__Modificacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Usuario__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Usuario__Creacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Usuario__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Usuario__Modificacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__UsuarioGrupo__Usuario] FOREIGN KEY([IdUsuarioGrupo])
REFERENCES [dbo].[UsuarioGrupo] ([IdUsuarioGrupo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__UsuarioGrupo__Usuario]
GO
ALTER TABLE [dbo].[UsuarioGrupo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__UsuarioGrupo__Creacion] FOREIGN KEY([IdUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioGrupo] CHECK CONSTRAINT [FK__Usuario__UsuarioGrupo__Creacion]
GO
ALTER TABLE [dbo].[UsuarioGrupo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__UsuarioGrupo__Modificacion] FOREIGN KEY([IdUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioGrupo] CHECK CONSTRAINT [FK__Usuario__UsuarioGrupo__Modificacion]
GO
ALTER TABLE [dbo].[UsuarioGrupoPermiso]  WITH CHECK ADD  CONSTRAINT [FK__UsuarioGrupo__UsuarioGrupoPermiso] FOREIGN KEY([IdUsuarioGrupo])
REFERENCES [dbo].[UsuarioGrupo] ([IdUsuarioGrupo])
GO
ALTER TABLE [dbo].[UsuarioGrupoPermiso] CHECK CONSTRAINT [FK__UsuarioGrupo__UsuarioGrupoPermiso]
GO
