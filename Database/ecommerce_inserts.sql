
-- =================================================================
-- Passwords are fictional bcrypt hashes for 'password123'
-- =================================================================

INSERT INTO users (first_name, last_name, email, password_hash, phone_number) VALUES
('John', 'Smith', 'john.smith@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0101'),
('Jane', 'Doe', 'jane.doe@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0102'),
('Peter', 'Jones', 'peter.jones@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0103'),
('Mary', 'Williams', 'mary.williams@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0104'),
('David', 'Brown', 'david.brown@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0105'),
('Susan', 'Davis', 'susan.davis@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0106'),
('Michael', 'Miller', 'michael.miller@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0107'),
('Linda', 'Wilson', 'linda.wilson@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0108'),
('James', 'Moore', 'james.moore@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0109'),
('Patricia', 'Taylor', 'patricia.taylor@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0110'),
('Robert', 'Anderson', 'robert.anderson@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0111'),
('Jennifer', 'Thomas', 'jennifer.thomas@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0112'),
('William', 'Jackson', 'william.jackson@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0113'),
('Elizabeth', 'White', 'elizabeth.white@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0114'),
('Richard', 'Harris', 'richard.harris@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0115'),
('Barbara', 'Martin', 'barbara.martin@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0116'),
('Joseph', 'Thompson', 'joseph.thompson@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0117'),
('Jessica', 'Garcia', 'jessica.garcia@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0118'),
('Charles', 'Martinez', 'charles.martinez@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0119'),
('Sarah', 'Robinson', 'sarah.robinson@example.com', '$2a$12$EaC5b8s2J5P2eW8h7d3fG.7qR4kL9wX1zY0uB3vA6cI9dO2eF4gH5', '555-0120');

-- =================================================================
-- Addresses
-- Each user has a shipping and billing address.
-- =================================================================

INSERT INTO addresses (user_id, address_line_1, city, postal_code, country, address_type) VALUES
(1000, '123 Maple Street', 'Springfield', '12345', 'USA', 'shipping'),
(1000, '123 Maple Street', 'Springfield', '12345', 'USA', 'billing'),
(1001, '456 Oak Avenue', 'Shelbyville', '67890', 'USA', 'shipping'),
(1001, '456 Oak Avenue', 'Shelbyville', '67890', 'USA', 'billing'),
(1002, '789 Pine Lane', 'Capital City', '10112', 'USA', 'shipping'),
(1002, '789 Pine Lane', 'Capital City', '10112', 'USA', 'billing'),
(1003, '101 Elm Court', 'Ogdenville', '13141', 'USA', 'shipping'),
(1003, '101 Elm Court', 'Ogdenville', '13141', 'USA', 'billing'),
(1004, '212 Birch Road', 'North Haverbrook', '51617', 'USA', 'shipping'),
(1004, '212 Birch Road', 'North Haverbrook', '51617', 'USA', 'billing'),
(1005, '333 Cedar Blvd', 'Springfield', '12345', 'USA', 'shipping'),
(1005, '333 Cedar Blvd', 'Springfield', '12345', 'USA', 'billing'),
(1006, '444 Spruce Way', 'Shelbyville', '67890', 'USA', 'shipping'),
(1006, '444 Spruce Way', 'Shelbyville', '67890', 'USA', 'billing'),
(1007, '555 Redwood Dr', 'Capital City', '10112', 'USA', 'shipping'),
(1007, '555 Redwood Dr', 'Capital City', '10112', 'USA', 'billing'),
(1008, '666 Aspen St', 'Ogdenville', '13141', 'USA', 'shipping'),
(1008, '666 Aspen St', 'Ogdenville', '13141', 'USA', 'billing'),
(1009, '777 Sequoia Ave', 'North Haverbrook', '51617', 'USA', 'shipping'),
(1009, '777 Sequoia Ave', 'North Haverbrook', '51617', 'USA', 'billing'),
(1010, '888 Willow Creek', 'Springfield', '12345', 'USA', 'shipping'),
(1010, '888 Willow Creek', 'Springfield', '12345', 'USA', 'billing'),
(1011, '999 Cypress Garden', 'Shelbyville', '67890', 'USA', 'shipping'),
(1011, '999 Cypress Garden', 'Shelbyville', '67890', 'USA', 'billing'),
(1012, '111 Magnolia Pl', 'Capital City', '10112', 'USA', 'shipping'),
(1012, '111 Magnolia Pl', 'Capital City', '10112', 'USA', 'billing'),
(1013, '222 Juniper Cir', 'Ogdenville', '13141', 'USA', 'shipping'),
(1013, '222 Juniper Cir', 'Ogdenville', '13141', 'USA', 'billing'),
(1014, '321 Poplar St', 'North Haverbrook', '51617', 'USA', 'shipping'),
(1014, '321 Poplar St', 'North Haverbrook', '51617', 'USA', 'billing'),
(1015, '432 Holly Ln', 'Springfield', '12345', 'USA', 'shipping'),
(1015, '432 Holly Ln', 'Springfield', '12345', 'USA', 'billing'),
(1016, '543 Sycamore Rd', 'Shelbyville', '67890', 'USA', 'shipping'),
(1016, '543 Sycamore Rd', 'Shelbyville', '67890', 'USA', 'billing'),
(1017, '654 Fir Ave', 'Capital City', '10112', 'USA', 'shipping'),
(1017, '654 Fir Ave', 'Capital City', '10112', 'USA', 'billing'),
(1018, '765 Walnut Blvd', 'Ogdenville', '13141', 'USA', 'shipping'),
(1018, '765 Walnut Blvd', 'Ogdenville', '13141', 'USA', 'billing'),
(1019, '876 Chestnut Way', 'North Haverbrook', '51617', 'USA', 'shipping'),
(1019, '876 Chestnut Way', 'North Haverbrook', '51617', 'USA', 'billing');

-- =================================================================
-- Categories (5)
-- =================================================================

INSERT INTO categories (category_name, description) VALUES
('Electronics', 'Gadgets, devices, and all things electronic.'),
('Books', 'Fiction, non-fiction, and everything in between.'),
('Home & Kitchen', 'Appliances, decor, and tools for your home.'),
('Apparel', 'Clothing for men, women, and children.'),
('Sports & Outdoors', 'Gear for an active lifestyle, both indoors and out.');

-- =================================================================
-- Products (50)
-- =================================================================

-- Electronics (Category 1)
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(1, 'Wireless Noise-Cancelling Headphones', 'Immerse yourself in sound with these premium headphones.', 299.99, 'ELEC-HDPH-001', 150),
(1, '4K Ultra HD Smart TV', 'Experience stunning visuals with this 55-inch smart TV.', 499.50, 'ELEC-TV-002', 80),
(1, 'Smartphone Pro', 'The latest in mobile technology with a stunning camera.', 999.00, 'ELEC-SPHN-003', 200),
(1, 'Gaming Laptop', 'High-performance laptop for the ultimate gaming experience.', 1499.99, 'ELEC-LPT-004', 45),
(1, 'Smartwatch Series X', 'Track your fitness, notifications, and more from your wrist.', 249.00, 'ELEC-SWCH-005', 300),
(1, 'Bluetooth Speaker', 'Portable and powerful sound for any occasion.', 79.99, 'ELEC-SPKR-006', 450),
(1, 'Digital Camera', 'Capture life''s moments in beautiful high resolution.', 650.00, 'ELEC-CAM-007', 70),
(1, 'E-Reader', 'Carry thousands of books in one lightweight device.', 129.99, 'ELEC-ERDR-008', 250),
(1, 'Wireless Charging Pad', 'Conveniently charge your devices without cables.', 39.99, 'ELEC-CHGR-009', 600),
(1, 'Computer Monitor', '27-inch QHD monitor for work and play.', 320.00, 'ELEC-MON-010', 120);

-- Books (Category 2)
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(2, 'The Midnight Library', 'A novel by Matt Haig.', 15.99, 'BOOK-FIC-001', 500),
(2, 'Atomic Habits', 'An Easy & Proven Way to Build Good Habits & Break Bad Ones by James Clear.', 19.50, 'BOOK-NONFIC-002', 800),
(2, 'Dune', 'Classic science fiction novel by Frank Herbert.', 22.00, 'BOOK-SCIFI-003', 350),
(2, 'The Silent Patient', 'A psychological thriller by Alex Michaelides.', 14.75, 'BOOK-THR-004', 420),
(2, 'Sapiens: A Brief History of Humankind', 'By Yuval Noah Harari.', 25.00, 'BOOK-HIST-005', 600),
(2, 'Where the Crawdads Sing', 'A novel by Delia Owens.', 18.00, 'BOOK-FIC-006', 750),
(2, 'Educated: A Memoir', 'A memoir by Tara Westover.', 17.99, 'BOOK-MEM-007', 300),
(2, 'The Lord of the Rings', 'J.R.R. Tolkien''s epic fantasy saga.', 35.50, 'BOOK-FNT-008', 250),
(2, 'Becoming', 'The memoir of former First Lady Michelle Obama.', 21.99, 'BOOK-MEM-009', 480),
(2, 'A Brief History of Time', 'From the Big Bang to Black Holes by Stephen Hawking.', 16.25, 'BOOK-SCI-010', 200);

-- Home & Kitchen (Category 3)
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(3, 'Espresso Machine', 'Brew barista-quality coffee at home.', 199.99, 'HOME-COFF-001', 110),
(3, 'Air Fryer', 'A healthier way to enjoy your favorite fried foods.', 89.95, 'HOME-FRY-002', 220),
(3, 'Robotic Vacuum Cleaner', 'Automatically cleans your floors.', 275.00, 'HOME-VAC-003', 90),
(3, 'Stand Mixer', 'The perfect kitchen companion for baking.', 349.99, 'HOME-MIX-004', 60),
(3, 'Chef''s Knife', 'High-carbon stainless steel knife for all your chopping needs.', 55.00, 'HOME-KNFE-005', 400),
(3, 'Non-Stick Cookware Set', '10-piece set for everyday cooking.', 150.00, 'HOME-COOK-006', 150),
(3, 'Electric Kettle', 'Quickly boil water for tea, coffee, or oatmeal.', 29.99, 'HOME-KTL-007', 500),
(3, 'Blender', 'Powerful blender for smoothies, soups, and more.', 120.00, 'HOME-BLND-008', 180),
(3, 'Weighted Blanket', 'Improve your sleep with a calming weighted blanket.', 79.99, 'HOME-BED-009', 250),
(3, 'Digital Food Scale', 'Accurate measurements for perfect recipes.', 19.99, 'HOME-SCL-010', 700);

-- Apparel (Category 4)
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(4, 'Men''s Classic T-Shirt', 'A comfortable and stylish 100% cotton t-shirt.', 19.99, 'APRL-M-TSHT-001', 1000),
(4, 'Women''s High-Waist Jeans', 'Flattering and durable denim jeans.', 59.50, 'APRL-W-JEAN-002', 600),
(4, 'Running Shoes', 'Lightweight and supportive shoes for runners.', 120.00, 'APRL-U-SHOE-003', 450),
(4, 'Winter Jacket', 'Waterproof and insulated jacket for cold weather.', 180.00, 'APRL-U-JKT-004', 200),
(4, 'Leather Belt', 'Classic genuine leather belt.', 35.00, 'APRL-M-BELT-005', 800),
(4, 'Summer Dress', 'A light and airy dress perfect for warm days.', 45.00, 'APRL-W-DRSS-006', 350),
(4, 'Wool Socks', 'Warm and comfortable merino wool socks (3-pack).', 25.00, 'APRL-U-SOCK-007', 1200),
(4, 'Men''s Chino Pants', 'Versatile and stylish pants for any occasion.', 49.99, 'APRL-M-PANT-008', 550),
(4, 'Women''s Blouse', 'Elegant silk blouse for work or evening wear.', 65.00, 'APRL-W-BLS-009', 400),
(4, 'Baseball Cap', 'Classic adjustable cotton baseball cap.', 15.00, 'APRL-U-HAT-010', 900);

-- Sports & Outdoors (Category 5)
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(5, 'Yoga Mat', 'Eco-friendly, non-slip mat for yoga and exercise.', 29.99, 'SPRT-YOGA-001', 800),
(5, '2-Person Camping Tent', 'Lightweight, waterproof tent for backpacking.', 129.99, 'SPRT-CAMP-002', 150),
(5, 'Insulated Water Bottle', 'Keeps drinks cold for 24 hours or hot for 12.', 24.50, 'SPRT-BTL-003', 1500),
(5, 'Hiking Backpack', '50L backpack with multiple compartments and rain cover.', 85.00, 'SPRT-PACK-004', 300),
(5, 'Adjustable Dumbbells', 'Set of two adjustable dumbbells, up to 50 lbs each.', 399.00, 'SPRT-FIT-005', 75),
(5, 'Basketball', 'Official size and weight basketball.', 29.99, 'SPRT-BALL-006', 600),
(5, 'Bicycle Helmet', 'Safety certified helmet with enhanced ventilation.', 49.99, 'SPRT-BIKE-007', 400),
(5, 'Fishing Rod and Reel Combo', 'A great starter kit for any angler.', 75.00, 'SPRT-FISH-008', 220),
(5, 'Jump Rope', 'Adjustable speed rope for cardio workouts.', 12.99, 'SPRT-FIT-009', 1000),
(5, 'Sleeping Bag', '3-season sleeping bag for camping comfort.', 99.99, 'SPRT-CAMP-010', 180);

-- =================================================================
-- Orders, Product_Order, and Payments
-- A few sample orders to link everything together.
-- =================================================================

-- Order 1000 for John Smith (user_id 1000)
INSERT INTO orders (user_id, total_amount, order_status, order_date, shipping_address_id, billing_address_id) VALUES (1000, 315.98, 'completed', '2025-08-10 10:30:00', 1, 2);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1000, 1000, 299.99, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1010, 1000, 15.99, 1);
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES (1000, 1000, 'Credit Card', 315.98, 'completed', '2025-08-10 10:31:00');

-- Order 1001 for Jane Doe (user_id 1001)
INSERT INTO orders (user_id, total_amount, order_status, order_date, shipping_address_id, billing_address_id) VALUES (1001, 109.94, 'shipped', '2025-08-12 14:00:00', 3, 4);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1021, 1001, 89.95, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1029, 1001, 19.99, 1);
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES (1001, 1001, 'PayPal', 109.94, 'completed', '2025-08-12 14:01:00');

-- Order 1002 for Peter Jones (user_id 1002)
INSERT INTO orders (user_id, total_amount, order_status, order_date, shipping_address_id, billing_address_id) VALUES (1002, 295.00, 'processing', '2025-08-15 09:15:00', 5, 6);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1032, 1002, 120.00, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1034, 1002, 35.00, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1040, 1002, 29.99, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1042, 1002, 24.50, 2);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1048, 1002, 12.99, 2);
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES (1002, 1002, 'Credit Card', 295.00, 'completed', '2025-08-15 09:16:00');

-- Order 1003 for Mary Williams (user_id 1003)
INSERT INTO orders (user_id, total_amount, order_status, order_date, shipping_address_id, billing_address_id) VALUES (1003, 999.00, 'cancelled', '2025-08-20 11:00:00', 7, 8);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1002, 1003, 999.00, 1);
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES (1003, 1003, 'Credit Card', 999.00, 'refunded', '2025-08-20 11:01:00');

-- Order 1004 for Robert Anderson (user_id 1010)
INSERT INTO orders (user_id, total_amount, order_status, order_date, shipping_address_id, billing_address_id) VALUES (1010, 52.49, 'shipped', '2025-08-21 18:45:00', 21, 22);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1012, 1004, 22.00, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1019, 1004, 16.25, 1);
INSERT INTO product_order (product_id, order_id, price, quantity) VALUES (1048, 1004, 12.99, 1);
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES (1010, 1004, 'Debit Card', 52.49, 'completed', '2025-08-21 18:46:00');