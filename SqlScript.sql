  insert into Songs values ('Marandhaye','D.Imman','Teddy','04:05',1,GETDATE())
  insert into Songs values ('Dosti','M.M.Keeravani','RRR','00:05:00',1,GETDATE())
  insert into Songs values ('Naanga Vera Maari','Yuvan Shankar Raja','Valimai','00:04:25',1,GETDATE())
  insert into Songs values ('Enjoy Enjaami','Santhosh','Enjoy Enjaami','00:04:25',1,GETDATE())
  insert into Songs values ('Mangalyam','S S Thaman','Eeswaran','00:04:35',1,GETDATE())
  insert into Songs values ('Andha Kanna paathakka','Anirudh','Master','00:04:05',1,GETDATE())

  Select * from Songs

  insert into PlayList values ('Playlist1',1,GETDATE())
  insert into PlayList values ('Playlist2',1,GETDATE())

  Select * from PlayList

  insert into PlayListSongs values (1,1,1,GETDATE())
  insert into PlayListSongs values (1,2,1,GETDATE())
  insert into PlayListSongs values (1,3,1,GETDATE())
  insert into PlayListSongs values (1,4,1,GETDATE())
  insert into PlayListSongs values (1,5,1,GETDATE())
  insert into PlayListSongs values (1,6,1,GETDATE())

  insert into PlayListSongs values (2,1,1,GETDATE())
  insert into PlayListSongs values (2,2,1,GETDATE())

  Select * from PlayListSongs


  Truncate table PlayListSongs

  Truncate table PlayList