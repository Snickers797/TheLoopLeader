﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoopLeader.Domain.Abstract;

namespace LoopLeader.Domain.Entities
{
public class Content : IContent
    {
        /*The Section property should tell which page/section we intend to modify.  I think this should refer to the actual
           entry in the database where the content is stored, not the page itself.*/
        public string ContentID { get; set; }
        //Obtain the current text in the section if we need it (maybe to automatically fill in an editable text box later for easy edits?)
        public string CurrentText { get; set; }
        //The new text that we want the section to have.
        public string NewText { get; set; }

        //The function to do the updating
        public void UpdateSection(string contentID, string newSectionInfo)
        {
            /*Psuedo-code for possible update method:
             Get Section to Update (passed in as function parameter above)
             If NewSectionInfo is < 750 characters
             {
             If Section is found in database
             {
             Replace entry in Database with the NewSectionInfo parameter
             }
             Else return an appropriate error message and do nothing.
             }
             */
        }
    }
}
