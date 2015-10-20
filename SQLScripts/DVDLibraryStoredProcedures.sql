USE DVDLibrary
GO


--Add the DVD
CREATE PROCEDURE AddDVD
(
 @Title varchar(140),
 @ReleaseDate date,
 @MPAA varchar(10),
 @Director varchar(90),
 @StudioID int
) AS

INSERT INTO DVDs (Title, ReleaseDate, MPAA, Director, StudioID)
VALUES (@Title, @ReleaseDate, @MPAA, @Director, @StudioID);

GO

--Return the number of the most recent DVD Created
CREATE PROCEDURE ReturnMostRecentDVDID
AS

SELECT MAX(DVDID)
FROM DVDs


GO

-- You'll have to call this for each actor
CREATE PROCEDURE AddDVDActorDetails
(
 @DVDID int,
 @ActorID int
) AS

INSERT INTO DVDActorDetails (DVDID, ActorID)
VALUES (@DVDID,@ActorID);
GO