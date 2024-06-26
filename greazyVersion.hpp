//
// $Id: greazyVersion.hpp 7503 2015-05-21 18:37:51Z chambm $
//

#ifndef _GREAZY_VERSION_HPP_
#define _GREAZY_VERSION_HPP_

#include <string>

namespace freicore {
namespace greazy {

struct Version
{
    static int Major();
    static int Minor();
    static int Revision();
    static std::string str();
    static std::string LastModified();
};

} // namespace greazy
} // namespace freicore

#endif // _GREAZY_VERSION_HPP_
