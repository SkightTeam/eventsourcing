﻿using CodeSharp.EventSourcing;
using EventSourcing.Sample.Model.BookBorrowAndReturn;

namespace EventSourcing.Sample.Application
{
    public interface ILibraryAccountService
    {
        LibraryAccount Create(string number, string owner);
    }
    public class LibraryAccountService : ILibraryAccountService
    {
        private IContextManager _contextManager;

        public LibraryAccountService(IContextManager contextManger)
        {
            _contextManager = contextManger;
        }

        public LibraryAccount Create(string number, string owner)
        {
            using (var context = _contextManager.GetContext())
            {
                var account = new LibraryAccount(number, owner);
                context.Add(account);
                context.SaveChanges();
                return account;
            }
        }
    }
}
