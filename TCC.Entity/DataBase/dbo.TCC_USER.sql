CREATE TABLE [dbo].[TCC_USER] (
    [ID_N]            INT           IDENTITY (1, 1) NOT NULL,
    [NAME_C]          VARCHAR (50)  NOT NULL,
    [EMAIL_C]         VARCHAR (250) NOT NULL,
    [PASSWORD_C]      NCHAR (150)   NOT NULL,
    [ADDED_DATE_D]    DATETIME      NOT NULL,
    [MODIFIED_DATE_D] DATETIME      NULL,
    [ACTIVE_B]        BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_N] ASC)
);

