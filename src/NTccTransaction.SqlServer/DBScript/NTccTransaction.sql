﻿CREATE TABLE [dbo].[NTCC_TRANSACTION] 
(
  [TRANSACTION_ID] varchar(128) NOT NULL 
  ,[GLOBAL_TRANSACTION_ID] varchar(128) NULL 
  ,[BRANCH_QUALIFIER] varchar(128) NULL 
  ,[STATUS] int NOT NULL 
  ,[TRANSACTION_TYPE] int NOT NULL 
  ,[RETRIED_COUNT] int NOT NULL 
  ,[CREATE_UTC_TIME] datetime NOT NULL 
  ,[LAST_UPDATE_UTC_TIME] datetime NOT NULL 
  ,[VERSION] int NOT NULL 
  ,[CONTENT] nvarchar(MAX) NULL 
  ,PRIMARY KEY 
  (
  	[TRANSACTION_ID]
  )
)

GO
