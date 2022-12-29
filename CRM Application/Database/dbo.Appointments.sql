CREATE TABLE [dbo].[Appointments] (
    [Id]                   INT           NOT NULL IDENTITY,
    [AppointmentStartTime] DATETIME      NOT NULL,
    [AppointmentEndTime]   DATETIME      NOT NULL,
    [ClientName]           VARCHAR (256) NOT NULL,
    [GraduateStudentName]  VARCHAR (256) NOT NULL,
    [RoomNumber]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

