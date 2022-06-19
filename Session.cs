using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Session {

        private static Session session;

        private Usuario user;
        private String jwt;

        public Session(Usuario user, string jwt) {
            this.user = user;
            this.jwt = jwt;
        }

        public Usuario getUser() {
            return user;
        }

        public String getJWT() {
            return jwt;
        }

        public static void setSession(Session sess) {
            session = sess;
        }

        public static Session getSession() {
            return session;
        }
    }
}
