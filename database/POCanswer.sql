-- Asssumptions
-- UserTable : 1 = Active #2=Not Active
-- ListingsTable: 2 =Basic #3=remium
#################################################################
###1. Select users whose id is either 3,2 or 4
###- Please return at least: all user fields
###################################################################

SELECT 
    *
FROM
    users
WHERE
    id IN (3 , 2, 4);

#################################################################
#2. Count how many basic and premium listings each active user has
#- Please return at least: first_name, last_name, basic, premium
#######################################################################

SELECT 
    u.id,
    u.first_name,
    u.last_name,
    COUNT(CASE
        WHEN (l.status = 2) THEN 1
        ELSE NULL
    END) AS 'Basic',
    COUNT(CASE
        WHEN (l.status = 3) THEN 1
        ELSE NULL
    END) AS 'premium'
FROM
    users AS u,
    listings AS l
WHERE
    u.id = l.user_id AND l.status IN (2 , 3)
        AND u.status = 1
GROUP BY u.id;

###################################################################
#3. Show the same count as before but only if they have at least ONE premium listing
#- Please return at least: first_name, last_name, basic, premium
####################################################################

SELECT 
    u.id,
    u.first_name,
    u.last_name,
    COUNT(CASE
        WHEN (l.status = 2) THEN 1
        ELSE NULL
    END) AS basic,
    COUNT(CASE
        WHEN (l.status = 3) THEN 1
        ELSE NULL
    END) AS premium
FROM
    users AS u,
    listings AS l
WHERE
    u.id = l.user_id AND l.status IN (2 , 3)
        AND u.status = 1
GROUP BY u.id
HAVING premium >= 1;

########################################################################
#4. How much revenue has each active vendor made in 2013
#- Please return at least: first_name, last_name, currency, revenue
#######################################################################

SELECT 
    u.first_name,
    u.last_name,
    c.currency,
    YEAR(c.created) AS 'year',
    SUM(c.price) AS 'revenue'
FROM
    users u
        LEFT JOIN
    listings l ON u.id = l.user_id
        LEFT JOIN
    clicks c ON l.id = c.listing_id
WHERE
    YEAR(c.created) = 2013 AND u.status = 1
GROUP BY u.id , c.currency , c.created;
 
###################################################################

 #5. Insert a new click for listing id 3, at $4.00
#- Find out the id of this new click. Please return at least: id
#######################################################################3

INSERT INTO clicks (`listing_id`, `price`) VALUES ('3', '4');

SELECT 
    *
FROM
    clicks
WHERE
    id = (SELECT LAST_INSERT_ID());

######################################################################
#6. Show listings that have not received a click in 2013
#- Please return at least: listing_name
###############################################################

SELECT DISTINCT
    l.name as listing_name
FROM
    listings l
        JOIN
    clicks c ON l.id = c.listing_id
WHERE
    YEAR(c.created) <> 2013;

#################################################################
#7. For each year show number of listings clicked and number of vendors who owned these listings
#- Please return at least: date, total_listings_clicked, total_vendors_affected
#select date, total_listings_clicked, total_vendors_affected
#####################################################################

#jOIN AND CTE
	With poc as (
SELECT DISTINCTROW
    l.id,
    (l.user_id),
    COUNT(c.listing_id) AS total_listings_clicked,
    c.created
FROM
    listings l
        RIGHT JOIN
    clicks c ON l.id = c.listing_id
GROUP BY l.id , c.listing_id , l.user_id , c.created
) 
SELECT 
    p.created AS date,
    p.total_listings_clicked,
    COUNT(pp.user_id) AS total_vendors_affected
FROM
    poc p
        JOIN
    poc pp ON p.id = pp.id
GROUP BY pp.user_id , p.id , p.total_listings_clicked , p.created;

#####################################################################
##########################################################################################
#8. Return a comma separated string of listing names for all active vendors
#- Please return at least: first_name, last_name, listing_names
##############################################################################################

SELECT DISTINCT
    u.first_name,
    u.last_name,
    (SELECT 
            GROUP_CONCAT(ll.name, '')
        FROM
            listings ll
        WHERE
            ll.user_id = l.user_id) as listing_names
FROM
    users u
        LEFT JOIN
    listings l ON u.id = l.user_id
 
 ##################################################################################################
 








