#!/usr/bin/env bash

docker run \
  --mount type=bind,source=$(pwd),target=/model/src \
  --entrypoint "/app/PublishModel.sh" \
  sailavid/ua-modelcompiler \
   /model/src/SkillsModel Opc.Ua.Skills /model/src/Published