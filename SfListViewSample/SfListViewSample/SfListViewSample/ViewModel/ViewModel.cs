﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.ListView.XForms;
using Xamarin.Forms.Internals;

namespace SfListViewSample
{
    [Preserve(AllMembers = true)]
    public class ViewModel
    {
        #region Fields

        private ObservableCollection<ListViewContactsInfo> contactsInfo;

        #endregion

        #region Constructor

        public ViewModel()
        {
            GenerateSource(30);
        }

        #endregion

        #region Properties

        public ObservableCollection<ListViewContactsInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ListViewContactsInfoRepository contactRepository = new ListViewContactsInfoRepository();
            contactsInfo = contactRepository.GetContactDetails(count);
        }

        #endregion
    }
}
