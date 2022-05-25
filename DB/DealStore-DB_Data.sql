SET IDENTITY_INSERT [dbo].[CategoryTbl] ON 
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (1, N'Tischler')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (2, N'Teckniker')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (3, N'Krankenpflege')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (4, N'Kinderbetreuer')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (5, N'Abriss- und Entsorgungsunternehmen ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (6, N'Bauplaner und -berater ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (7, N'Bauunternehmen ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (8, N'Betonbohrer und -schneider ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (9, N'Boden- und Estrichleger ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (10, N'Brunnenbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (11, N'Dachdecker ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (12, N'Elektriker ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (13, N'Erdbau- und Baggerunternehmen ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (14, N'Fenster-, Türen- und Markisenbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (15, N'Fliesen-, Platten-, Mosaikleger ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (16, N'Garten- und Landschaftsbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (17, N'Gebäudereiniger ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (18, N'Gerüstbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (19, N'Glaser ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (20, N'Heizungsbauer und Installateur ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (21, N'Holz- und Bautenschützer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (22, N'Innenarchitekt ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (23, N'Kaminbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (24, N'Kfz-Techniker ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (25, N'Klimatechniker ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (26, N'Küchen- und Möbelaufbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (27, N'Maler und Lackierer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (28, N'Maurer und Betonbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (29, N'Metallbauer und -verarbeiter ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (30, N'Monteur und Allroundhandwerker ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (31, N'Pflaster- und Straßenbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (32, N'Poolbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (33, N'Raumausstatter ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (34, N'Sanitärinstallateur ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (35, N'Sattler und Polsterer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (36, N'Stuckateur und Verputzer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (37, N'Tischler und Schreiner ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (38, N'Transportunternehmen ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (39, N'Treppenbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (40, N'Trockenbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (41, N'Umzugsunternehmen ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (42, N'Zaunbauer ')
GO
INSERT [dbo].[CategoryTbl] ([Id], [Name]) VALUES (43, N'Zimmerer ')
GO
SET IDENTITY_INSERT [dbo].[CategoryTbl] OFF
GO
INSERT [dbo].[UserTbl] ([UserRef], [UserName], [UserPass], [Firstname], [Lastname], [Email], [Adress], [Mobile], [City], [Zip], [IsNotifyEmail], [IsNotifySms], [IsServiceProvider], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (N'657dd571-88f7-41f2-802d-14f3198777db', N'admin1', N'admin1', N'Wael', N'Amer', N'wael.amer@gmail.com', N'Grunwaldgasse ', N'06767168685', N'WIEN', N'1050', 1, 1, 1, CAST(N'2021-12-14T10:59:57.760' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[UserTbl] ([UserRef], [UserName], [UserPass], [Firstname], [Lastname], [Email], [Adress], [Mobile], [City], [Zip], [IsNotifyEmail], [IsNotifySms], [IsServiceProvider], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (N'd72f872f-7a50-448e-9a5d-4eaa4aff5669', N'admin2', N'admin2', N'Mohamed', N'Elashkr', N'Mohamed.Elashkr@gmail.com', N'Gernotgasse 1/Ecke Wehrbrücklstr.38-40', N'06716865246', N'WIEN', N'1220', 1, 1, 1, CAST(N'2021-12-14T14:04:27.300' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceTbl] ON 
GO
INSERT [dbo].[ServiceTbl] ([Id], [UserRef], [Name], [Description_Short], [Description], [CategoryId], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (1, N'd72f872f-7a50-448e-9a5d-4eaa4aff5669', N'Umzugsunternehmen', N'Transport Firma Gesucht', N'Transport, Entsorgung Umzug und Entrümpelung
Umzüge mit kurzer Wegstrecke, innerstädtische Umzüge
Sonstige Transportdienstleistungen (Abholung, Lieferung, Entsorgung)', 41, CAST(N'2022-01-14T09:54:46.503' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ServiceTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[RequestTbl] ON 
GO
INSERT [dbo].[RequestTbl] ([Id], [ServiceID], [UserRef], [Status], [Description], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (1, 1, N'657dd571-88f7-41f2-802d-14f3198777db', N'Request', N'test', CAST(N'2022-01-15T07:28:07.970' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[RequestTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProviderTbl] ON 
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (3, N'657dd571-88f7-41f2-802d-14f3198777db', N'Adam update Vincze Gasgeräte und Sanitärservice Updated', N'Unternehmens-Beschreibung
Gasgeräte & Sanitärservice

Wartung, Reparatur, Abgasmessung, Abflussverstopfung...usw.

SERIÖS,FREUNDLICH,ZUVERLÄSSIG

!!ERÖFFNUNGSANGEBOTE!!', N'1.jpg', N'Tischler', CAST(N'2021-12-14T11:00:07.290' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (5, N'657dd571-88f7-41f2-802d-14f3198777db', N'Schwing', N'Maler updated und LackiererHeizungsbauer und InstallateurKüchen- und MöbelaufbauerBoden- und EstrichlegerElektrikerMonteur und AllroundhandwerkerZimmererSanitärinstallateurDachdeckerGebäudereinigerTischler und SchreinerRaumausstatter', N'2.svg', N'Sanitärinstallateur', CAST(N'2021-12-14T14:02:38.507' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (8, N'657dd571-88f7-41f2-802d-14f3198777db', N'Profi-Therm Gasgerätetechnik', N'Unternehmens-Beschreibung
Unternehmen für Gas Wasser Heizungstechnik 
Gasgeräte und vieles mehr ... 
www.profi-therm.at

', N'3.jpg', N'Sanitärinstallateur', CAST(N'2022-01-14T09:02:14.777' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (9, N'657dd571-88f7-41f2-802d-14f3198777db', N'Gasthermenwartung', N'Unternehmens-Beschreibung
Lakic Installationen
Gas-Wasser-Heizung
Ihr freundlicher Spezialist für Bad, Heizung und Gasgeräte', N'4.jpg', N'Klimatechniker', CAST(N'2022-01-14T09:04:28.433' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (10, N'657dd571-88f7-41f2-802d-14f3198777db', N'Diana Sanitärtechnik GmbH', N'Unternehmens-Beschreibung
Diana Sanitärtechnik GmbH arbeitet als Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker und bietet Diensleistungen in den Bereichen Installation und Reparatur von Warmwasser- und Heizanlagen, Installation und Reparatur von Rohrleitungen und Wasseranschlüssen, Badsanierung, Verlegen von Fußbodenheizungen, Anschluss und Austausch von Armaturen, Anschluss und Reparatur von Gasherden und -leitungen, Einbau und Austausch von Bad- und Sanitärobjekten in der Umgebung von Wien, Favoriten, an.', N'5.jpg', N'Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker', CAST(N'2022-01-14T09:06:12.357' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (11, N'657dd571-88f7-41f2-802d-14f3198777db', N'Grill Haustechnik', N'Unternehmens-Beschreibung', N'6.jpg', N'Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker', CAST(N'2022-01-14T09:06:14.420' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (12, N'657dd571-88f7-41f2-802d-14f3198777db', N'MSED Installationen KG', N'Unternehmens-Beschreibung
Wir sind ein Installateur Betrieb in 1150 Wien und betreuen Sie gerne im Bereich Gas - Sanitär - Heizung - Lüftungsinstallation. Wir sind in Wien und Wien Umgebung für Sie unterwegs!

Zu unseren kleinen Arbeiten zählen zum Beispiel Küchen- Waschtisch Armaturen tauschen, Waschmaschinenanschluss herstellen oder WC tausch.

Falls Sie vorhaben Ihr Bad zu Sanieren oder ihre Heizungsanlage zu erneuern Kontaktieren sie uns, um sich einen Kostenlosen Beratungstermin auszumachen! Da gehen wir mit ihnen alles durch und senden ihnen im Anschluss ein unverbindliches Angebot zu.

Bei Fragen sind wir gerne telefonisch und per E-Mail für Sie da.

Wir freuen uns sie Betreuen zu dürfen!', N'7.jpg', N'Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker', CAST(N'2022-01-14T09:06:16.700' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (13, N'657dd571-88f7-41f2-802d-14f3198777db', N'SHP Installationen Harald Ertl', N'Unternehmens-Beschreibung
SHP Installationen Harald Ertl arbeitet als Heizungsbauer und Installateur, Sanitärinstallateur,  bietet Dienstleistungen in den Bereichen Installation und Reparatur von Warmwasser- und Heizanlagen, Installation und Reparatur von Rohrleitungen und Wasseranschlüssen, Verlegen von Fußbodenheizungen, Anschluss und Austausch von Armaturen, Anschluss und Reparatur von Gasherden und -leitungen, Einbau und Austausch von Bad- und Sanitärobjekten, Installation und Reparatur von Solar-Warmwasserspeichern in der Umgebung von Wien, Wien Umgebung an.', N'8.svg', N'Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker', CAST(N'2022-01-14T09:06:19.357' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (14, N'657dd571-88f7-41f2-802d-14f3198777db', N'Kanalvorsorge-Gell e.U.', N'Unternehmens-Beschreibung', N'9.jpg', N'Straßenbauer Sanitärinstallateur,
 Dachdecker, Gebäudereiniger, Klimatechniker, Raumausstatter', CAST(N'2022-01-14T09:06:21.517' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (15, N'657dd571-88f7-41f2-802d-14f3198777db', N'Folgs Installationen GmbH', N'Unternehmens-Beschreibung
Folgs Installationen GmbH arbeitet als Heizungsbauer und Installateur, Sanitärinstallateur, Klimatechniker, Bauunternehmen, Dachdecker, Maurer und Betonbauer, Kaminbauer und bietet Diensleistungen in den Bereichen Installation und Reparatur von Warmwasser- und Heizanlagen, Installation und Reparatur von Rohrleitungen und Wasseranschlüssen, Installation und Reparatur von Klimaanlagen, Badsanierung, Verlegen von Fußbodenheizungen, Anschluss und Austausch von Armaturen, Sonstige Arbeiten an Heizung, Sanitär und Klima, Anschluss und Reparatur von Gasherden und -leitungen, Aufbau und Anschluss von Kaminen und Öfen, Einbau und Austausch von Bad- und Sanitärobjekten, Einbau und Wartung von Öl- und Gastanks in der Umgebung von Wien, Simmering, an.', N'10.jpg', N'Heizungsbauer und Installateur, Bauunternehmen, Sanitärinstallateur', CAST(N'2022-01-14T09:06:26.063' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (16, N'657dd571-88f7-41f2-802d-14f3198777db', N'Badsanierer', N'Unternehmens-Beschreibung', N'11.jpg', N'Heizungsbauer und Installateur, Bauunternehmen, Sanitärinstallateur', CAST(N'2022-01-14T09:06:28.793' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[ProviderTbl] ([Id], [UserRef], [CompanyName], [CompanyDescription], [CompanyLogo], [Occupation], [CreatedDatetimeOn], [CreatedBy], [UpdatedDatetimeOn], [UpdatedBy]) VALUES (17, N'657dd571-88f7-41f2-802d-14f3198777db', N'new Adam Vincze Gasgeräte und Sanitärservice', N'Unternehmens-Beschreibung
Gasgeräte & Sanitärservice

Wartung, Reparatur, Abgasmessung, Abflussverstopfung...usw.

SERIÖS,FREUNDLICH,ZUVERLÄSSIG

!!ERÖFFNUNGSANGEBOTE!!', N'1.jpg', N'Tischler', CAST(N'2021-12-14T11:00:07.290' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ProviderTbl] OFF
GO
