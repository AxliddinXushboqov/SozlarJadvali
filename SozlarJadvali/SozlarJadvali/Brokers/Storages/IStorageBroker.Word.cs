﻿using SozlarJadvali.Models.Words;

namespace SozlarJadvali.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Word> InsertWordAsync(Word word);
        IQueryable<Word> SelectAllWords();
        ValueTask<Word> SelectWordByIdAsync(Guid id);
        ValueTask<Word> UpdateWordAsync(Word word);
        ValueTask<Word> DeleteWordAsync(Word word);
    }
}
