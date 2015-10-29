USE CarDealershipInventory
GO


CREATE TRIGGER RequestTrigger ON RequestForInfo
FOR UPDATE 
AS
BEGIN
DECLARE @RequestID int
SELECT @RequestID = RequestID from inserted
UPDATE RequestForInfo
SET LastContactDate = getdate()
WHERE @RequestID = RequestID
END
--ALTER TABLE RequestForInfo
--ADD DEFAULT (CURRENT_TIMESTAMP) FOR LastContactDate


INSERT INTO RequestForInfo (VehicleID, Name, Email, PhoneNumber, BestTimeToCall, PreferredContact, TimeframeToPurchase, AdditionalInfo, [Status])
VALUES
(1, 'Walker', 'wildchild@crazy.com', '555-111-2222', 'During lunch', 'phone', 'After i kick some butt', 'I like monster trucks', 'New'),
(2, 'Texas Ranger', 'spidermokey@crazy.com', '555-123-4567', 'After my nap', 'email', 'When I grow up', 'I''m all jacked up on Mountain Dew!', 'Future Prospect'),
(2, 'Ricky Bobby', 'ricky@whooooo.com', '555-333-7777', 'Midnight', 'phone', 'ASAP', 'I wanna go fast!', 'New'),
(3, 'Cal', 'cal@.snbcom', '555-999-4321', 'When I''m parting', 'phone', 'Maybe next year', 'Anything with a trunk', 'Awaiting Reply') 

INSERT INTO Vehicle (Make, Model, [Year], Mileage, AdTitle, [Description], Price, urlPicture, isAvailable)
VALUES
('Ford', 'Super Duty', '2015-01-01', 0, 'This is one bad truck', 'Big bad truck, great for getting into trouble.', 39999.99, 'https://www.google.com/search?q=2015+ford+super+duty&espv=2&biw=1366&bih=667&source=lnms&tbm=isch&sa=X&sqi=2&ved=0CAYQ_AUoAWoVChMI1NTIhJzlyAIVwSomCh330Q1c#imgrc=f94xOgbLZDctGM%3A', 1),
('Jaguar', 'XJ220', '2014-01-01', 9350, 'So fast you''ll poop', 'Words can''t describe the speed, take it for a test drive', 415000.00, 'https://www.google.com/search?q=2015+ford+super+duty&espv=2&biw=1366&bih=667&source=lnms&tbm=isch&sa=X&sqi=2&ved=0CAYQ_AUoAWoVChMI1NTIhJzlyAIVwSomCh330Q1c#tbm=isch&q=jaguar+xj220&imgrc=jqLA1On24LJGMM%3A', 1),
('Pontiac', 'Grand Prix', '1997-01-01', 205000, 'Just a car', 'Gets you from point A to point B, most of the time.', 2995.00, 'https://www.google.com/search?q=2015+ford+super+duty&espv=2&biw=1366&bih=667&source=lnms&tbm=isch&sa=X&sqi=2&ved=0CAYQ_AUoAWoVChMI1NTIhJzlyAIVwSomCh330Q1c#tbm=isch&q=1997+pontiac+grand+prix&imgrc=LkI5_JKJ1ShRHM%3A', 1)

INSERT INTO StatusOfRequest ([Status], [Description])
VALUES
('New', 'Every request starts with a status of New'),
('Awaiting Reply', 'Salesman contacted and waiting for reply'),
('Future Prospect', 'Not purchasing at this time but will follow up in the future'),
('Lost Opportunity', 'Purchased a vehicle somewhere else')

UPDATE RequestForInfo
SET PreferredContact = 'phone'
WHERE VehicleID = 1

SELECT *
FROM RequestForInfo







