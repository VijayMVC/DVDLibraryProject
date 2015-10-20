USE DVDLibrary
GO


--Add the DVD
ALTER PROCEDURE SP_AddDVD
(
 @Title varchar(140),
 @ReleaseDate date,
 @MPAA varchar(10),
 @Director varchar(90),
 @StudioID int
) AS

INSERT INTO DVDs (Title, ReleaseDate, MPAA, Director, StudioID)  OUTPUT Inserted.DVDID
VALUES (@Title, @ReleaseDate, @MPAA, @Director, @StudioID);

GO

--Return the number of the most recent DVD Created
ALTER PROCEDURE SP_ReturnMostRecentDVDID
AS

SELECT MAX(DVDID)
FROM DVDs
RETURN 


GO

-- You'll have to call this for each actor
ALTER PROCEDURE SP_AddDVDActorDetails
(
 @DVDID int,
 @ActorID int
) AS

INSERT INTO DVDActorDetails (DVDID, ActorID)
VALUES (@DVDID,@ActorID);
GO