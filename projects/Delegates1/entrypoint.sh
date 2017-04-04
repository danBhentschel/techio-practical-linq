#!/bin/bash

echo "CG> redirect-streams --input out null"

cd /project/target

echo "CG> message --channel \"execution progress\" Building..."
dotnet test --filter "FullyQualifiedName=$1" --verbosity="quiet" >build.out 2>&1
result=$?
echo "CG> message --channel \"execution progress\" Done"
if [ $result -eq 0 ]; then
    echo "CG> success true"
else
    echo "CG> success false"
fi

/parse_build_out.pl build.out

rm -f build.out
