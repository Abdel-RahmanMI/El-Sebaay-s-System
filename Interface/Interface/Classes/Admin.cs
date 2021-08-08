using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{

    class Admin
    {
        private String name;
        private long phone;
        private String address;
        private String email;
        private long psw;
        private int Id;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public long getPhone()
        {
            return phone;
        }

        public void setPhone(long phone)
        {
            this.phone = phone;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public long getPsw()
        {
            return psw;
        }

        public void setPsw(long psw)
        {
            this.psw = psw;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }
    }
}
