-- User
INSERT INTO dbo.[User] (Username, Email, HashedPassword, Salt, IsLocked, DateCreated)
	VALUES (N'vutran', N'tnmvu93@gmail.com', N'XwAQoiq84p1RUzhAyPfaMDKVgSwnn80NCtsE8dNv3XI=', N'mNKLRbEFCH8y1xIyTXP4qA==', 0, '2017-04-04 22:34:44')

-- Role
INSERT INTO dbo.Role (Name) VALUES (N'Admin')

-- UserRole
INSERT INTO dbo.UserRole (UserId, RoleId) VALUES (1, 1)

-- Genre
INSERT INTO dbo.Genre (Name) VALUES (N'Comedy')
INSERT INTO dbo.Genre (Name) VALUES (N'Sci-fi')
INSERT INTO dbo.Genre (Name) VALUES (N'Action')
INSERT INTO dbo.Genre (Name) VALUES (N'Horror')
INSERT INTO dbo.Genre (Name) VALUES (N'Romance')
INSERT INTO dbo.Genre (Name) VALUES (N'Crime')

-- Movie
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Minions', N'Minions Stuart, Kevin and Bob are recruited by Scarlet Overkill, a super-villain who, alongside her inventor husband Herb, hatches a plot to take over the world.',
			N'minions.jpg', 1, N'Kyle Bald', N'Brian Lynch', N'Janet Healy', '2015-07-10', 3, N'https://www.youtube.com/watch?v=Wfql_DoHRKc')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Ted 2', N'Newlywed couple Ted and Tami-Lynn want to have a baby, but in order to qualify to be a parent, Ted will have to prove he''s a person in a court of law.',
			N'ted2.jpg', 1, N'Seth MacFarlane', N'Seth MacFarlane', N'Jason Clark', '2015-06-27', 4, N'https://www.youtube.com/watch?v=S3AVcCggRnU')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Trainwreck', N'Having thought that monogamy was never possible, a commitment-phobic career woman may have to face her fears when she meets a good guy.',
			N'trainwreck.jpg', 2, N'Judd Apatow', N'Amy Schumer', N'Judd Apatow', '2015-06-17', 5, N'https://www.youtube.com/watch?v=2MxnhBPoIx4')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Inside Out', N'After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.',
			N'insideout.jpg', 1, N'Pete Docter', N'Pete Docter', N'John Lasseter', '2015-06-19', 4, N'https://www.youtube.com/watch?v=seMwpP0yeu4')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Home', N'Oh, an alien on the run from his own people, lands on Earth and makes friends with the adventurous Tip, who is on a quest of her own.',
			N'home.jpg', 1, N'Tim Johnson', N'Tom J. Astle', N'Suzanne Buirgy', '2015-05-27', 4, N'https://www.youtube.com/watch?v=MyqZf8LiWvM')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Batman v Superman: Dawn of Justice', N'Fearing the actions of a god-like Super Hero left unchecked, Gotham City''s own formidable, forceful vigilante takes on Metropolis most revered, modern-day savior, while the world wrestles with what sort of hero it really needs. And with Batman and Superman at war with one another, a new threat quickly arises, putting mankind in greater danger than it''s ever known before.',
			N'batmanvssuperman.jpg', 2, N'Zack Snyder', N'Chris Terrio', N'Wesley Coller', '2015-03-25', 4, N'https://www.youtube.com/watch?v=0WWzgGyAH6Y')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Ant-Man', N'Armed with a super-suit with the astonishing ability to shrink in scale but increase in strength, cat burglar Scott Lang must embrace his inner hero and help his mentor, Dr. Hank Pym, plan and pull off a heist that will save the world.',
			N'antman.jpg', 2, N'Payton Reed', N'Edgar Wright', N'Victoria Alonso', '2015-07-17', 5, N'https://www.youtube.com/watch?v=1HpZevFifuo')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Jurassic World', N'A new theme park is built on the original site of Jurassic Park. Everything is going well until the park''s newest attraction--a genetically modified giant stealth killing machine--escapes containment and goes on a killing spree.',
			N'jurassicworld.jpg', 2, N'Colin Trevorrow', N'Rick Jaffa', N'Patrick Crowley', '2015-06-12', 4, N'https://www.youtube.com/watch?v=RFinNxS5KN4')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Fantastic Four', N'Four young outsiders teleport to an alternate and dangerous universe which alters their physical form in shocking ways. The four must learn to harness their new abilities and work together to save Earth from a former friend turned enemy.',
			N'fantasticfour.jpg', 2, N'Josh Trank', N'Simon Kinberg', N'Avi Arad', '2015-8-7', 4, N'https://www.youtube.com/watch?v=AAgnQdiZFsQ')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Mad Max: Fury Road', N'In a stark desert landscape where humanity is broken, two rebels just might be able to restore order: Max, a man of action and of few words, and Furiosa, a woman of action who is looking to make it back to her childhood homeland.',
			N'madmax.jpg', 2, N'George Miller', N'George Miller', N'Bruce Berman', '2015-5-15', 3, N'https://www.youtube.com/watch?v=hEJnMQG9ev8')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'True Detective', N'An anthology series in which police investigations unearth the personal and professional secrets of those involved, both within and outside the law.',
			N'truedetective.jpg', 6, N'Nic Pizzolatto', N'Bill Bannerman', N'Richard Brown', '2015-5-15', 4, N'https://www.youtube.com/watch?v=TXwCoNwBSkQ')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'The Longest Ride', N'After an automobile crash, the lives of a young couple intertwine with a much older man, as he reflects back on a past love.',
			N'thelongestride.jpg', 5, N'Nic Pizzolatto', N'George Tillman Jr.', N'Marty Bowen', '2015-5-15', 5, N'https://www.youtube.com/watch?v=FUS_Q7FsfqU')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'The Walking Dead', N'Sheriff''s Deputy Rick Grimes leads a group of survivors in a world overrun by zombies.',
			N'thewalkingdead.jpg', 4, N'Frank Darabont', N'David Alpert', N'Gale Anne Hurd', '2015-3-28', 5, N'https://www.youtube.com/watch?v=R1v0uFms68U')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Southpaw', N'Boxer Billy Hope turns to trainer Tick Willis to help him get his life back on track after losing his wife in a tragic accident and his daughter to child protection services.',
			N'southpaw.jpg', 3, N'Antoine Fuqua', N'Kurt Sutter', N'Todd Black', '2015-8-17', 4, N'https://www.youtube.com/watch?v=Mh2ebPxhoLs')
INSERT INTO dbo.Movie (Title, Description, Image, GenreId, Director, Writer, Producer, ReleaseDate, Rating, TrailerURI)
	VALUES (N'Specter', N'A cryptic message from Bond''s past sends him on a trail to uncover a sinister organization. While M battles political forces to keep the secret service alive, Bond peels back the layers of deceit to reveal the terrible truth behind SPECTRE.',
			N'spectre.jpg', 3, N'Sam Mendes', N'Ian Fleming', N'Zakaria Alaoui', '2015-11-5', 5, N'https://www.youtube.com/watch?v=LTDaET-JweU')

-- Stock
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (1, '7dbe54f8-0e81-4a50-a925-9384d74335ab', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (1, '96c23602-0c6e-455a-96e1-c3042681b41c', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (1, '4c8b854e-6146-4763-8730-ff0a84726f41', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (2, 'cad9dd6f-aa2a-421d-848d-6d6dfa913b7e', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (2, '55ce10b1-e280-4fdf-bbec-32c0ec03b72d', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (2, '092d3e6a-bf25-4548-9afa-f913176c3ec2', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (3, '5994ddce-6507-4fbe-9f76-d83dab23e815', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (3, '7a479653-1454-4d0f-8095-13b617fecf64', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (3, '0b89906b-cbb1-4b70-a778-65264b3ad667', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (4, '88c1a7f7-e4ba-400b-8abb-a8763a46058e', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (4, '136044c6-eeca-45bb-9980-9effa8dc68c0', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (4, 'de12cc37-e1d2-44c4-a7b3-2dc21475b1c4', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (5, '2c5d0c49-dbe8-414f-85ff-eca8a0fd9024', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (5, '4ed5bf82-7485-42c0-89c1-4b9dc9b75d54', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (5, '8968fe9e-a729-446e-9f1f-85aba2f5e5d6', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (6, '87bc2bd5-a02f-4f6f-9cc6-7f21c8596011', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (6, 'cd582804-3765-4b78-b46c-a47319112217', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (6, 'fafa8e27-9b86-4fac-b1a0-8f50e1259daf', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (7, 'a3437a65-9a33-4c4b-92a4-c5beccd75cd6', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (7, 'a21218d6-73c4-4135-b6b2-6d9c2b5524ac', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (7, 'b815a51a-7611-4050-b54e-1f82e9d7be94', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (8, '5cebc917-8ef9-407d-b901-6b8c33a1d807', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (8, 'bc4480b1-7996-4668-8025-7e42010020f5', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (8, 'a294882c-0c56-4067-9648-f6e00ddd86a8', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (9, '2a6bb7f2-1aed-4258-9540-f00abb352a26', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (9, '00f21816-486e-483a-ad4c-eff84ab6fe55', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (9, '39a69318-59d2-44e1-9e7f-2fb888105ce0', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (10, '0cf1702f-7757-4667-ac4d-98e2043beb8f', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (10, '0cd3b045-8cb8-4910-b046-3308fb80d31a', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (10, '18352b77-73a5-4d32-af2e-b0578c66c12b', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (11, '76d949bd-9836-43ba-8997-80f3e95a75a4', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (11, 'e2f6ab66-7ecd-4a09-aa42-bd068aab2941', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (11, '6b539fb5-ccd5-4108-8a8a-a66f74bf23d2', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (12, 'cf20a65f-9bfd-42bc-b69c-a02fca8cf51e', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (12, '0f108171-6077-4a6a-b711-e84ffb282c0b', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (12, '72bf5b88-de54-496f-97ee-37e3023e8199', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (13, 'dcb439e0-3692-4b6f-90f5-ae95feb5c985', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (13, '19245322-dc4c-4b69-a2b3-4ea789f6c095', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (13, '4aa513f4-b567-4038-a4d0-f0d016894445', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (14, '297b8f82-cb0e-4186-9b86-77fdba312eb4', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (14, '2204470e-2e5d-49c5-b916-61e639c50eaa', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (14, '7560b975-fc11-41bd-a5c8-4d6a546bdfb5', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (15, '326fe0b2-6533-4447-9f7d-a085f1cb6d8f', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (15, 'e96c0891-d716-4fe5-b930-0d33b3e2c9b2', 1)
INSERT INTO dbo.Stock (MovieId, UniqueKey, IsAvailable) VALUES (15, 'b7ae07b6-85b9-44e8-81c9-b830fd679089', 1)


