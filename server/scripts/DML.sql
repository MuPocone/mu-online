USE MuOnline
GO

IF(NOT EXISTS (SELECT * FROM [INFORMATION_SCHEMA].[TABLES] AS [t] WHERE [t].[TABLE_NAME] = 'Perfil'))
	BEGIN 
		PRINT 'Tabela [Perfil] não existe! Rode o script DDL primeiro.' 
	END
ELSE
	INSERT INTO [site].[Perfil] (Id, Descricao) VALUES (1,'Usuario'), (2,'GM'), (3,'Admin')
GO

----Limpar o banco de dados
--delete from [MuOnline].[dbo].[GameServerInfo]
--delete from [MuOnline].[dbo].[C_PlayerKiller_Info]
--delete from [MuOnline].[dbo].[T_CGuid]
--delete from [MuOnline].[dbo].[GuildMember]
--delete from [MuOnline].[dbo].[Guild]
--delete from [MuOnline].[dbo].[IGC_CancelItemSale]
--delete from [MuOnline].[dbo].[IGC_EvoMonRanking]
--delete from [MuOnline].[dbo].[IGC_Gens]
--delete from [MuOnline].[dbo].[IGC_PeriodItemInfo]
--delete from [MuOnline].[dbo].[OptionData]
--delete from [MuOnline].[dbo].[PetWarehouse]
--delete from [MuOnline].[dbo].[T_Event_Inventory]
--delete from [MuOnline].[dbo].[T_FriendList]
--delete from [MuOnline].[dbo].[T_FriendMail]
--delete from [MuOnline].[dbo].[T_FriendMain]
--delete from [MuOnline].[dbo].[T_GMSystem]
--delete from [MuOnline].[dbo].[T_InGameShop_Items]
--delete from [MuOnline].[dbo].[T_InGameShop_Point]
--delete from [MuOnline].[dbo].[T_PentagramInfo]
--delete from [MuOnline].[dbo].[T_PetItem_Info]
--delete from [MuOnline].[dbo].[T_PSHOP_ITEMVALUE_INFO]
--delete from [MuOnline].[dbo].[T_QUEST_EXP_INFO]
--delete from [MuOnline].[dbo].[warehouse]
--delete from [MuOnline].[dbo].[Character]
--delete from [MuOnline].[dbo].[AccountCharacter]
--delete from [MuOnline].[dbo].[ConnectionHistory]
--delete from [MuOnline].[dbo].[T_VIPList]
--delete from [MuOnline].[dbo].[MEMB_STAT]
--delete from [MuOnline].[dbo].[MEMB_INFO]
