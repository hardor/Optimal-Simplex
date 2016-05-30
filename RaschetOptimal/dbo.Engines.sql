CREATE TABLE [dbo].[Engines] (
    [Id]                                                           INT             IDENTITY (1, 1) NOT NULL,
    [Наименование средства]                                        NTEXT           NOT NULL,
    [Скорость движения, км/ч]                                     DECIMAL (18, 2) NOT NULL,
    [Время, необходимое на погрузку, мин]                          DECIMAL (18, 2) NOT NULL,
    [Возможность перевозки эвакуируемого населения за 1 рейс, чел] DECIMAL (18, 3) NOT NULL,
    [Влияние течения в затопленной области]                        BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

