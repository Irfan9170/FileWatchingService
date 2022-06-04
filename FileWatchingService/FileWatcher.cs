using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatchingService
{
    public class FileWatcher
    {
        private FileSystemWatcher _fileWatcher;
        public FileWatcher()
        {
            _fileWatcher = new FileSystemWatcher(@"F:\learning");
            _fileWatcher.Created += new FileSystemEventHandler(_fileWatcher_Created);
            _fileWatcher.EnableRaisingEvents = true;

        }

        void _fileWatcher_Created(object sender,FileSystemEventArgs e)
        {
            ChangeLogger.Log(String.Format("File Changed: Path:{0},Name:{1}",e.FullPath,e.Name));
        }
    }
}
