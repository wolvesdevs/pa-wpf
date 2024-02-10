-- テーブル新規作成
CREATE TABLE [dbo].[Weather] (
    [AreaId]      INT      NOT NULL,
    [DataDate]    DATETIME NOT NULL,
    [Condition]   INT      NOT NULL,
    [Temperature] REAL     NOT NULL,
    CONSTRAINT [PK_Weather] PRIMARY KEY CLUSTERED ([AreaId] ASC, [DataDate] ASC)
);

CREATE TABLE [dbo].[Areas] (
    [AreaId]   INT  NOT NULL,
    [AreaName] TEXT NOT NULL,
    CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED ([AreaId] ASC)
);

-- 初期データ挿入
INSERT Weather
	(AreaId, DataDate, Condition, Temperature)
VALUES
	(1, '2018-08-10', 1, 31.2345),
	(1, '2018-08-11', 2, 30.2345),
	(2, '2018-08-11', 3, 23.332);

INSERT Areas
	(AreaId, AreaName)
VALUES
	(1, '東京'),
	(2, '静岡'),
	(3, '神戸');