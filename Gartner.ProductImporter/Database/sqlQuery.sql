SELECT id,first_name,Last_name,Email,[Status],Created FROM users where id in (2,3,4)
----------------
Select u.first_name,u.last_name,
 CASE l.status
           WHEN 2
           THEN 'Basic'
           WHEN 3
           THEN 'Premium'
           ELSE 'Unknown'
       END AS statusDescription
,count(l.status) as total from users u inner join listings l
on u.id=l.user_id --where l.status=2
group by u.first_name,u.last_name,l.status
-----------------

select u.first_name,u.last_name,
 CASE l.status
           WHEN 2
           THEN 'Basic'
           WHEN 3
           THEN 'Premium'
           ELSE 'Unknown'
       END AS statusDescription
,count(l.status) as total from users u inner join listings l
on u.id=l.user_id where l.status=3 
group by u.first_name,u.last_name,l.status
having count(l.status)>=1
-----------------------------
select u.first_name,u.last_name,c.currency,sum(c.price) as revenue from users u inner join listings l
on u.id=l.user_id inner join clicks c on c.listing_id=l.id where year(c.created)=2013 and u.status=2
group by u.first_name,u.last_name,c.currency
----------------------------------------------
INSERT INTO clicks VALUES (3,4.00,'USD','2013-09-15 16:18:43')
select IDENT_CURRENT('clicks')
-------------------------------------
select distinct listing_id from clicks where listing_id not in 
(select listing_id from clicks where year(created)=2013)



