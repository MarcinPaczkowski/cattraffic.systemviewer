CREATE TABLE [CatTraffic].[ExternalData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TriggerId] [int] NOT NULL,
	[WeightId] [int] NOT NULL,
	[TriggerLineNumber] [int] NOT NULL,
	[WeightLineNumber] [int] NOT NULL,
	[TriggerDate] [datetime] NOT NULL,
	[WeightDate] [datetime] NOT NULL,
	[Direction] [int] NOT NULL,
	[VehicleType] [int] NOT NULL,
	[Speed] [int] NOT NULL,
	[VehicleLength] [int] NOT NULL,
	[VehicleGap] [int] NOT NULL,
	[Volation] [int] NOT NULL,
	[TotalLoad] [int] NOT NULL,
	[OverloadSA] [int] NOT NULL,
	[OverloadMA] [int] NOT NULL,
	[OverloadTL] [int] NOT NULL,
 CONSTRAINT [PK_ExternalData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]