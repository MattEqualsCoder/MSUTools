function get_json_obj()
{
    var prevJson = $("#input_box").val();
    if (!prevJson) return undefined;
    return JSON.parse(prevJson);
}

function swap() {
    var obj = get_json_obj();
    if (!obj) return;
    var prevTracks = obj.tracks;
    prevTracks.forEach(track => {
        if (track.track_number < 99) {
            track.track_number = 100 + track.track_number;
        }
        else if (track.track_number > 100) {
            track.track_number = track.track_number - 100;
        }
    });
    prevTracks.sort((a, b) => { return a.track_number - b.track_number })
    $("#output_box").val(JSON.stringify(obj, null, 2));

    var trackNames = "";

    prevTracks.forEach(track => {
        trackNames += track.title + ",";
    })
}

function to_yaml(){
    var obj = get_json_obj();
    if (!obj) return;
    var old = $("#metroid_first").prop('checked');
    var use_track_title = $("#track_title").prop('checked');
    var use_file_name = $("#file_title").prop('checked');
    var do_not_copy_artist = $("#do_not_copy_artist").prop('checked');
    var include_comment = $("#include_comment").prop('checked');

    var pack_name = obj.pack ?? "";
    var artist = do_not_copy_artist ? "" : (obj.artist ?? "");
    var album = $("#album").val() ?? "";

    var output = "pack_name: " + pack_name + "\n";
    output += "pack_author: \n";
    output += "pack_version: 1\n";
    output += "tracks: \n";

    if (obj.tracks.filter(x => !x.track_number).length > 0) {
        $("#errors").text("All tracks must have a track number").show();
        return;
    }

    if (obj.tracks.filter(x => !x.title).length > 0) {
        $("#errors").text("All tracks must have a track title").show();
        return;
    }

    var errors = "";
    obj.tracks.forEach(track => {
        var convert_tracks = [];
        if (old) {
            convert_tracks = convert_data.filter(x => x.old == track.track_number);
        } else {
            convert_tracks = convert_data.filter(x => x.new == track.track_number);
        }
        if (convert_tracks.length != 1) {
            errors += "Track " + track.title + " has an invalid track number<br />";
            return;
        }
        var track_title = convert_tracks[0].name;
        var song_name = "";
        if (use_track_title) {
            song_name = track.title;
        }
        if (use_file_name) {
            song_name = track.file;
            if (!track.file) {
                errors += "Track " + track.title + " does not have a file specified<br />";
                song_name = "";
            } else {
                song_name = song_name.substring(0, song_name.lastIndexOf("."));
                if (song_name.includes('\\')) {
                    song_name = song_name.substring(song_name.lastIndexOf('\\')+1);
                }
                if (song_name.includes('/')) {
                    song_name = song_name.substring(song_name.lastIndexOf('/')+1);
                }
            }
        }
        if (include_comment) {
            output += `  # Track Number: ${track.track_number}\n`;
        }
        output += `  ${track_title}:\n`;
        output += `    name: ${song_name}\n`;
        output += `    artist: ${artist}\n`;
        output += `    album: ${album}\n`;
    });

    if (errors) {
        $("#errors").html(errors).show();
    } else {
        $("#errors").hide();
    }
    $("#output_box").val(output);
}

function copy_output() {
    var copyText = document.getElementById("output_box");
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    navigator.clipboard.writeText(copyText.value);
    console.log("copied");
}

$("#zelda_first").change(function() {
    if (this.checked) {
        $("#metroid_first").prop('checked', false);
    } else {
        $("#metroid_first").prop('checked', true);
    }
});

$("#metroid_first").change(function() {
    if (this.checked) {
        $("#zelda_first").prop('checked', false);
    } else {
        $("#zelda_first").prop('checked', true);
    }
});

$("#track_title").change(function() {
    if (this.checked) {
        $("#file_title").prop('checked', false);
    }
});

$("#file_title").change(function() {
    if (this.checked) {
        $("#track_title").prop('checked', false);
    }
});