using System;
using System.Collections.Generic;

namespace addressBook {
    class AddressBook {
        Dictionary<string, Contact> AddressBooks = new Dictionary<string, Contact> ();

        public void AddContact (string Email, Contact contact) {
            try {
                AddressBooks.Add (Email, contact);
            } catch
                (ArgumentException ex) {
                    Console.WriteLine ($"This contact already exists: {ex.Message}");

            }
        }
        public Contact GetByEmail (string email) {
            return AddressBooks[email];
        }

        // foreach (string Email in AddressBooks) {
        //         if (Email == email) {

        //             cardHolder.CheckoutBook (book);
        //             book.IsAvailable = false;

        //         }
        //     }

    }
}