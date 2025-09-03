

INSERT INTO users (first_name, last_name, email, password_hash, phone_number) VALUES
('Ana', 'Horvat', 'ana.horvat@example.com', 'hash_placeholder_1', '+385912345678'),
('Ivan', 'Kovaèiæ', 'ivan.kovacic@example.com', 'hash_placeholder_2', '+385987654321'),
('Petra', 'Novak', 'petra.novak@example.com', 'hash_placeholder_3', '+385951112233'),
('Marko', 'Mariæ', 'marko.maric@example.com', 'hash_placeholder_4', '+385994455667'),
('Jelena', 'Babiæ', 'jelena.babic@example.com', 'hash_placeholder_5', '+385923344556'),
('Luka', 'Kovaèeviæ', 'luka.kovacevic@example.com', 'hash_placeholder_6', '+385978899001'),
('Marija', 'Juriæ', 'marija.juric@example.com', 'hash_placeholder_7', '+385915566778'),
('Filip', 'Horvat', 'filip.horvat@example.com', 'hash_placeholder_8', '+385981231234'),
('Iva', 'Vukoviæ', 'iva.vukovic@example.com', 'hash_placeholder_9', '+385958765432'),
('Tomislav', 'Kneževiæ', 'tomislav.knezevic@example.com', 'hash_placeholder_10', '+385993214321'),
('Sara', 'Matiæ', 'sara.matic@example.com', 'hash_placeholder_11', '+385919876543'),
('Nikola', 'Periæ', 'nikola.peric@example.com', 'hash_placeholder_12', '+385921122334'),
('Katarina', 'Šimiæ', 'katarina.simic@example.com', 'hash_placeholder_13', '+385976543210'),
('Domagoj', 'Petroviæ', 'domagoj.petrovic@example.com', 'hash_placeholder_14', '+385988877665'),
('Lucija', 'Markoviæ', 'lucija.markovic@example.com', 'hash_placeholder_15', '+385955554433');


INSERT INTO addresses (user_id, address_line_1, city, postal_code, country, address_type) VALUES
-- User 1000 (Ana Horvat)
(1000, 'Ilica 15', 'Zagreb', '10000', 'Croatia', 'shipping'),
(1000, 'Trg Bana Jelaèiæa 1', 'Zagreb', '10000', 'Croatia', 'billing'),
-- User 1001 (Ivan Kovaèiæ)
(1001, 'Vukovarska 210', 'Split', '21000', 'Croatia', 'shipping'),
(1001, 'Riva 5', 'Split', '21000', 'Croatia', 'billing'),
-- User 1002 (Petra Novak)
(1002, 'Korzo 33', 'Rijeka', '51000', 'Croatia', 'shipping'),
(1002, 'Jadranski Trg 4', 'Rijeka', '51000', 'Croatia', 'billing'),
-- User 1003 (Marko Mariæ)
(1003, 'Kapucinska 25', 'Osijek', '31000', 'Croatia', 'shipping'),
(1003, 'Trg Ante Starèeviæa 10', 'Osijek', '31000', 'Croatia', 'billing'),
-- User 1004 (Jelena Babiæ)
(1004, 'Stradun 12', 'Dubrovnik', '20000', 'Croatia', 'shipping'),
(1004, 'Poljana Paska Milièeviæa 4', 'Dubrovnik', '20000', 'Croatia', 'billing'),
-- User 1005 (Luka Kovaèeviæ)
(1005, 'Preradoviæeva 5', 'Zagreb', '10000', 'Croatia', 'shipping'),
(1005, 'Preradoviæeva 5', 'Zagreb', '10000', 'Croatia', 'billing'),
-- User 1006 (Marija Juriæ)
(1006, 'Marmontova ulica 3', 'Split', '21000', 'Croatia', 'shipping'),
(1006, 'Marmontova ulica 3', 'Split', '21000', 'Croatia', 'billing'),
-- User 1007 (Filip Horvat)
(1007, 'Ulica Slobode 11', 'Split', '21000', 'Croatia', 'shipping'),
(1007, 'Ulica Slobode 11', 'Split', '21000', 'Croatia', 'billing'),
-- User 1008 (Iva Vukoviæ)
(1008, 'Gunduliæeva 22', 'Zagreb', '10000', 'Croatia', 'shipping'),
(1008, 'Gunduliæeva 22', 'Zagreb', '10000', 'Croatia', 'billing'),
-- User 1009 (Tomislav Kneževiæ)
(1009, 'Adamiæeva 17', 'Rijeka', '51000', 'Croatia', 'shipping'),
(1009, 'Adamiæeva 17', 'Rijeka', '51000', 'Croatia', 'billing'),
-- User 1010 (Sara Matiæ)
(1010, 'Široka ulica 14', 'Zadar', '23000', 'Croatia', 'shipping'),
(1010, 'Široka ulica 14', 'Zadar', '23000', 'Croatia', 'billing'),
-- User 1011 (Nikola Periæ)
(1011, 'Gajeva 2', 'Zagreb', '10000', 'Croatia', 'shipping'),
(1011, 'Gajeva 2', 'Zagreb', '10000', 'Croatia', 'billing'),
-- User 1012 (Katarina Šimiæ)
(1012, 'Županijska 3', 'Osijek', '31000', 'Croatia', 'shipping'),
(1012, 'Županijska 3', 'Osijek', '31000', 'Croatia', 'billing'),
-- User 1013 (Domagoj Petroviæ)
(1013, 'Bosanska 5', 'Split', '21000', 'Croatia', 'shipping'),
(1013, 'Bosanska 5', 'Split', '21000', 'Croatia', 'billing'),
-- User 1014 (Lucija Markoviæ)
(1014, 'Tkalèiæeva 8', 'Zagreb', '10000', 'Croatia', 'shipping'),
(1014, 'Tkalèiæeva 8', 'Zagreb', '10000', 'Croatia', 'billing');

-- Inserting 5 Categories
INSERT INTO categories (category_name, description) VALUES
('Electronics', 'Gadgets, devices, and accessories to make your life easier and more fun.'),
('Books', 'Physical copies of fiction, non-fiction, and educational books.'),
('Clothing', 'Apparel for men, women, and children for all seasons.'),
('Home & Garden', 'Products for decorating your home and tending your garden.'),
('Sports & Outdoors', 'Equipment and apparel for your favorite sports and outdoor activities.');

-- Inserting 50 Products
-- Category 1: Electronics
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(1, 'Wireless Mouse', 'Ergonomic wireless mouse with a long-lasting battery.', 25.99, 'ELEC-WM-001', 150),
(1, 'Bluetooth Headphones', 'Over-ear noise-cancelling Bluetooth headphones.', 79.99, 'ELEC-BTH-002', 80),
(1, 'Mechanical Keyboard', 'RGB backlit mechanical keyboard with blue switches.', 65.50, 'ELEC-MK-003', 120),
(1, '4K Webcam', 'Ultra HD 4K webcam for streaming and video conferencing.', 99.99, 'ELEC-WBC-004', 60),
(1, 'USB-C Hub', '7-in-1 USB-C hub with HDMI, SD card reader, and USB 3.0 ports.', 35.00, 'ELEC-UCH-005', 200),
(1, 'Portable Power Bank', '20000mAh portable power bank with fast charging.', 45.99, 'ELEC-PPB-006', 180),
(1, 'Smartwatch', 'Fitness tracking smartwatch with heart rate monitor.', 129.99, 'ELEC-SW-007', 90),
(1, 'Gaming Monitor', '27-inch 144Hz gaming monitor with 1ms response time.', 299.99, 'ELEC-GM-008', 40),
(1, 'Wireless Earbuds', 'True wireless earbuds with charging case.', 55.00, 'ELEC-TWE-009', 250),
(1, 'Tablet Stand', 'Adjustable aluminum tablet stand.', 19.99, 'ELEC-TS-010', 300);

-- Category 2: Books
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(2, 'The Midnight Library', 'A novel by Matt Haig.', 15.99, 'BOOK-ML-001', 100),
(2, 'Atomic Habits', 'An easy & proven way to build good habits & break bad ones by James Clear.', 18.50, 'BOOK-AH-002', 200),
(2, 'Dune', 'Classic science fiction novel by Frank Herbert.', 12.99, 'BOOK-DN-003', 150),
(2, 'Sapiens: A Brief History of Humankind', 'A book by Yuval Noah Harari.', 22.00, 'BOOK-SP-004', 120),
(2, 'The Lord of the Rings', 'J.R.R. Tolkien''s fantasy epic.', 25.00, 'BOOK-LR-005', 90),
(2, '1984', 'A dystopian novel by George Orwell.', 9.99, 'BOOK-1984-006', 300),
(2, 'Pride and Prejudice', 'A classic romance novel by Jane Austen.', 8.50, 'BOOK-PP-007', 250),
(2, 'To Kill a Mockingbird', 'A novel by Harper Lee.', 11.25, 'BOOK-TKM-008', 180),
(2, 'The Great Gatsby', 'A novel by F. Scott Fitzgerald.', 10.00, 'BOOK-GG-009', 220),
(2, 'The Hobbit', 'A fantasy novel by J.R.R. Tolkien.', 13.50, 'BOOK-HB-010', 170);

-- Category 3: Clothing
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(3, 'Men''s Cotton T-Shirt', 'A classic crew neck t-shirt made of 100% cotton.', 19.99, 'CLO-MCT-001', 500),
(3, 'Women''s Denim Jeans', 'High-waisted skinny fit denim jeans.', 49.99, 'CLO-WDJ-002', 300),
(3, 'Unisex Hoodie', 'A comfortable fleece-lined hoodie.', 39.99, 'CLO-UH-003', 400),
(3, 'Men''s Leather Belt', 'Genuine leather belt with a classic buckle.', 29.50, 'CLO-MLB-004', 200),
(3, 'Women''s Summer Dress', 'A light and airy floral summer dress.', 55.00, 'CLO-WSD-005', 150),
(3, 'Running Shoes', 'Lightweight and breathable running shoes for men and women.', 89.99, 'CLO-RS-006', 250),
(3, 'Winter Scarf', 'A warm and soft knitted winter scarf.', 24.99, 'CLO-WS-007', 350),
(3, 'Men''s Chino Shorts', 'Comfortable and stylish chino shorts.', 34.00, 'CLO-MCS-008', 180),
(3, 'Women''s Blouse', 'An elegant silk blouse for work or casual wear.', 45.00, 'CLO-WB-009', 120),
(3, 'Pack of 3 Socks', 'Cotton-blend ankle socks.', 12.99, 'CLO-P3S-010', 600);

-- Category 4: Home & Garden
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(4, 'Scented Candle', 'Lavender scented soy wax candle.', 15.99, 'HG-SC-001', 400),
(4, 'Ceramic Plant Pot', 'A modern ceramic pot for indoor plants.', 22.50, 'HG-CPP-002', 250),
(4, 'Kitchen Knife Set', 'A 5-piece stainless steel kitchen knife set with a wooden block.', 79.99, 'HG-KNS-003', 100),
(4, 'Plush Throw Blanket', 'A soft and cozy fleece throw blanket.', 35.00, 'HG-PTB-004', 300),
(4, 'Garden Tool Set', 'A 3-piece set including a trowel, transplanter, and cultivator.', 29.99, 'HG-GTS-005', 180),
(4, 'Picture Frame', 'A wooden 8x10 picture frame.', 18.00, 'HG-PF-006', 500),
(4, 'Wall Clock', 'A minimalist 12-inch wall clock.', 40.00, 'HG-WC-007', 150),
(4, 'Bamboo Cutting Board', 'An extra-large organic bamboo cutting board.', 25.99, 'HG-BCB-008', 220),
(4, 'LED Desk Lamp', 'A modern LED desk lamp with adjustable brightness.', 32.50, 'HG-LDL-009', 190),
(4, 'Door Mat', 'A durable coir doormat with a non-slip backing.', 19.99, 'HG-DM-010', 350);

-- Category 5: Sports & Outdoors
INSERT INTO products (category_id, name, description, price, sku, stock_quantity) VALUES
(5, 'Yoga Mat', 'An extra-thick, non-slip yoga mat.', 30.00, 'SO-YM-001', 200),
(5, '2-Person Camping Tent', 'A lightweight, waterproof tent for two people.', 120.00, 'SO-TCT-002', 70),
(5, 'Insulated Water Bottle', 'A 32 oz stainless steel insulated water bottle.', 25.00, 'SO-IWB-003', 600),
(5, 'Hiking Backpack', 'A 40L durable backpack for hiking and travel.', 75.50, 'SO-HB-004', 130),
(5, 'Bicycle Helmet', 'An adjustable and ventilated helmet for cycling.', 45.00, 'SO-BH-005', 180),
(5, 'Jump Rope', 'A speed jump rope with adjustable length.', 14.99, 'SO-JR-006', 400),
(5, 'Resistance Bands Set', 'A set of 5 resistance loop bands for exercise.', 18.99, 'SO-RBS-007', 300),
(5, 'Soccer Ball', 'A standard size 5 soccer ball.', 22.00, 'SO-SB-008', 250),
(5, 'Camping Chair', 'A portable and foldable camping chair.', 35.00, 'SO-CC-009', 150),
(5, 'Fishing Rod Combo', 'A telescopic fishing rod and reel combo kit.', 65.00, 'SO-FRC-010', 90);

-- =================================================================
-- Creating a cart for each user
INSERT INTO carts (user_id) VALUES
(1000), (1001), (1002), (1003), (1004), (1005), (1006), (1007),
(1008), (1009), (1010), (1011), (1012), (1013), (1014);

-- Adding some products to a few carts
-- Cart 1 (User 1000)
INSERT INTO cart_product (cart_id, product_id, quantity) VALUES
(1, 1001, 1), -- Bluetooth Headphones
(1, 1010, 1); -- The Midnight Library
-- Cart 3 (User 1002)
INSERT INTO cart_product (cart_id, product_id, quantity) VALUES
(3, 1020, 2), -- Men's Cotton T-Shirt
(3, 1021, 1); -- Women's Denim Jeans
-- Cart 5 (User 1004)
INSERT INTO cart_product (cart_id, product_id, quantity) VALUES
(5, 1040, 1), -- Yoga Mat
(5, 1042, 1); -- Insulated Water Bottle

-- Order 1 for User 1001 (Ivan Kovaèiæ)
INSERT INTO orders (user_id, total_amount, order_status, shipping_address_id, billing_address_id, order_date) VALUES
(1001, 114.98, 'completed', 3, 4, '2025-08-15 10:30:00');
INSERT INTO product_order (order_id, product_id, price, quantity) VALUES
(1000, 1001, 79.99, 1), -- Bluetooth Headphones
(1000, 1030, 34.99, 1); -- Plush Throw Blanket (Price slightly different at time of purchase)
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES
(1001, 1000, 'Credit Card', 114.98, 'completed', '2025-08-15 10:31:00');

-- Order 2 for User 1003 (Marko Mariæ)
INSERT INTO orders (user_id, total_amount, order_status, shipping_address_id, billing_address_id, order_date) VALUES
(1003, 120.99, 'shipped', 7, 8, '2025-08-20 14:00:00');
INSERT INTO product_order (order_id, product_id, price, quantity) VALUES
(1001, 1011, 18.50, 1), -- Atomic Habits
(1001, 1041, 120.00, 1); -- 2-Person Camping Tent
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES
(1003, 1001, 'PayPal', 138.50, 'completed', '2025-08-20 14:01:00');


-- Order 3 for User 1004 (Jelena Babiæ)
INSERT INTO orders (user_id, total_amount, order_status, shipping_address_id, billing_address_id, order_date) VALUES
(1004, 84.98, 'processing', 9, 10, '2025-09-01 09:15:00');
INSERT INTO product_order (order_id, product_id, price, quantity) VALUES
(1002, 1024, 55.00, 1), -- Women's Summer Dress
(1002, 1026, 29.98, 1); -- Winter Scarf (Price slightly different at time of purchase)
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES
(1004, 1002, 'Credit Card', 84.98, 'completed', '2025-09-01 09:16:00');


-- Order 4 for User 1007 (Filip Horvat)
INSERT INTO orders (user_id, total_amount, order_status, shipping_address_id, billing_address_id, order_date) VALUES
(1007, 39.98, 'pending', 15, 16, '2025-09-02 11:05:00');
INSERT INTO product_order (order_id, product_id, price, quantity) VALUES
(1003, 1020, 19.99, 2); -- Men's Cotton T-Shirt
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES
(1007, 1003, 'Stripe', 39.98, 'pending', '2025-09-02 11:06:00');

-- Order 5 for User 1010 (Sara Matiæ)
INSERT INTO orders (user_id, total_amount, order_status, shipping_address_id, billing_address_id, order_date) VALUES
(1010, 105.98, 'shipped', 21, 22, '2025-08-28 18:45:00');
INSERT INTO product_order (order_id, product_id, price, quantity) VALUES
(1004, 1003, 65.50, 1), -- Mechanical Keyboard
(1004, 1004, 40.48, 1); -- 4K Webcam (Price slightly different at time of purchase)
INSERT INTO payments (user_id, order_id, pay_method, total_amount, payment_status, payment_date) VALUES
(1010, 1004, 'Credit Card', 105.98, 'completed', '2025-08-28 18:46:00');