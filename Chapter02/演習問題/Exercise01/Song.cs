using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    class Song {
        //プロパティ
        public string Title { get; set; }
        public string ArtistName { get; set; }      
        public int Length { get; set; }     //演奏時間（秒）

        //2.1.2
        public Song(string title,string artistname,int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;

        }


    }
}
